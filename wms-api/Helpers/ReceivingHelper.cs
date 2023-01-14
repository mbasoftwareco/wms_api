using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using wms_api.ErpConnector;
using wms_api.Models;
using wms_api.Utils;
using wms_api.Wrappers;

namespace wms_api.Helpers
{
    public class ReceivingHelper
    {

        // private WMS_LIGERO_LIVEContext db = new WMS_LIGERO_LIVEContext();

        private IConfiguration Configuration;
        private string CurrentUser;

        private WMS_LIGERO_LIVEContext _db = new WMS_LIGERO_LIVEContext();

        public ReceivingHelper() { }

        public ReceivingHelper(IConfiguration _configuration)
        {
            this.Configuration = _configuration;
            this._db = new WMS_LIGERO_LIVEContext();

        }

        public async Task<dynamic> ReceivingAction(ProcessRequest payload)
        {
            //  payload.parameters HACER CAST CON  ProcessReceivingRequest


            switch (payload.action)
            {
                case "LIST":
                    return GetReceivingList(payload);

                case "DOCUMENT":
                    return GetReceivingDocument(payload);

                case "ASSIGNDOC":
                    return GetReceivingDocument(payload);

                case "RCV_ITEMQTY":
                    return PostReceivingPickItemQty(payload);


                case "CONFIRM":
                    // ENVIO AL ERP Y A LOS SISTEMAS DE DESPACHOS (FEDEX, UPS, ,ETC...)
                    return await PostReceivingConfirmationAsync(payload);

                /* 
                                case "ROLLBACK":
                                    // ENVIO AL ERP Y A LOS SISTEMAS DE DESPACHOS (FEDEX, UPS, ,ETC...)
                                    return await RollBackReceivingConfirmationAsync(payload);
                */

                default:
                    return GetReceivingDocument(payload);
            }

        }


        public dynamic GetReceivingList(ProcessRequest payload)
        {
            WH_Obj curWMSObject = new WH_Obj { USERNAME = payload.username, DOCUMENT = payload.document, SITE = payload.site };
            return (new _WEB(this.Configuration)).sp_Receiving(payload.action, curWMSObject);
        }

        public dynamic GetReceivingDocument(ProcessRequest payload)
        {
            WH_Obj curWMSObject = new WH_Obj { USERNAME = payload.username, DOCUMENT = payload.document, SITE = payload.site, DATA_CAPTURED = payload.data_captured, SESSION_ID = payload.session_id };
            return (new _WEB(this.Configuration)).sp_Receiving(payload.action, curWMSObject);
        }


        public dynamic PostReceivingPickItemQty(ProcessRequest payload)
        {
            WH_Obj curWMSObject = new WH_Obj
            {
                USERNAME = payload.username,
                DOCUMENT = payload.document,
                DATA_CAPTURED = payload.data_captured,
                SESSION_ID = payload.session_id,
                SITE = payload.site
            };

            try { curWMSObject.STEP = payload.step; }
            catch { }

            return (new _WEB(this.Configuration)).sp_Receiving(payload.action, curWMSObject);
        }



        public async Task<dynamic> PostReceivingConfirmationAsync(ProcessRequest payload, bool useThread = false, bool onlyPrepare = false)
        {

            _WEB curContext = new _WEB(this.Configuration);

            V2OpeDocument opeDoc = curContext.db.V2OpeDocuments.FirstOrDefault(f => f.Docnumber == payload.document && f.Postedon != null);

            //validar si ya fue confirmado antes - retorna sin procesarlo.
            if (opeDoc != null)
                return new WMSResponse<dynamic>("Process Completed OK! " + opeDoc.Postedon.Value.ToShortDateString());

            //Prepara los procesos que debe ejecutar ese documento para enviar al ERP
            //EJ: IMPORMEDICAL - "Despacho Siempresalud - B32Impor" 
            /*
             Entrega en SAP de Impormedical con el siguiente campo de SF DocEntry_factura_Immedical__c (parece que hubiese una equivocación con el nombre del campo, pero una vez creado ya no lo pudimos modificar, por esta razón debe quedar así).
             Entrega en SAP Immedical con el campo de SF DocEntry_factura__c
             Entrada en SAP Immedical con el campo de SF DocEntry_Acreedores__c
             Update de info en SALESFORCE
             estos pasos se pueden comprobar en el siguiente caso: 500050000058Fn6AAE
            */

            WH_Obj curWMSObject = null;
            string guidSyncBatch = "";

            try
            {
                //Preparando la integracion con el ERP
                curWMSObject = new WH_Obj
                {
                    USERNAME = payload.username,
                    DOCUMENT = payload.document
                };

                try
                {
                    guidSyncBatch = curContext.sp_Receiving("ERP_PREPARE_CONFIRM", curWMSObject).Tables[0].Rows[0][0].ToString();
                }
                catch { }

                if (string.IsNullOrEmpty(guidSyncBatch))
                    throw new Exception(UtilTool.getLangInfo("BATCH_GUID_EMPTY"));

                if (onlyPrepare)
                    return "Prepare OK";

                //Proceso que ejecuta las integraciones con el ERP 
                //14 AGO 2022 - se decide poner en un proceso en hilo.
                if (useThread)
                {
                    Thread th = new Thread(new ParameterizedThreadStart(ProcessErpSyncBatch_Thread));
                    SyncBatch curTrx = new SyncBatch { guid = guidSyncBatch, username = payload.username };
                    th.Start(curTrx);
                    return new WMSResponse<dynamic>(UtilTool.getLangInfo("PROCESS_COMPLETED"));
                }
                else
                {
                    var result = await ProcessErpSyncBatch(guidSyncBatch, payload.username);
                    return result;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async void ProcessErpSyncBatch_Thread(Object curTrx)
        {
            SyncBatch batch = (SyncBatch)curTrx;
            await ProcessErpSyncBatch(batch.guid, batch.username);
        }

        private async Task<dynamic> ProcessErpSyncBatch(string guidSyncBatch, string username)
        {

            _WEB curContext = new _WEB(this.Configuration);
            string result = "";
            string curResponse = "";
            int hasErrors = 0;

            List<V2ApiIntegrationControl> syncList = curContext.db.V2ApiIntegrationControls
                .Where(f => f.BatchGuid == guidSyncBatch).OrderBy(f => f.Rowid).ToList();

            foreach (V2ApiIntegrationControl curSync in syncList)
            {
                curResponse = "";

                object[] erpConnection = UtilTool.ERP_GetConnection(curSync.SetupCode, curSync.Site, curContext.db);

                ConnectFactory erpFactory = ConnectFactory.GetConnectFactory(new WMSErpRequest
                {
                    curContext = curContext,
                    curConfig = erpConnection[0] as V2MasterConfig,
                    curErpCnn = erpConnection[1] as V2MasterConnection
                });

                WH_Obj curWMSObject = new WH_Obj
                {
                    SITE = curSync.Site,
                    DOCUMENT = curSync.Docnumber,
                    USERNAME = curSync.Createdby,
                    payloadAction = curSync.Action,
                    SESSION_ID = guidSyncBatch,
                    DATA_CAPTURED = curSync.SetupCode //GL : cuando es multiples transaciones para identificar cual es el metodo a validar.
                };

                try
                {
                    curResponse = (await erpFactory.ErpService().ConfirmReceivingErp(curWMSObject)).message;
                    curSync.StatusId = 501; //OK
                }
                catch (Exception ex)
                {
                    hasErrors++;
                    curResponse = ex.Message;
                    curSync.StatusId = 510; //Error
                }

                //update record
                curSync.ResponseData = curResponse;
                curSync.Modifiedby = username;
                curSync.Modifiedon = DateTime.Now;

                curContext.db.SaveChanges();

                result += curResponse + "\n------\n";
            }

            bool SendErrorERP = false;

            try
            {
                SendErrorERP = (_db.SParametros.FirstOrDefault(c => c.CodParametro == "SendErrorERP")).ValorParametro.Equals("T");
            }
            catch
            {

            }

            if (hasErrors > 0 && SendErrorERP)
                throw new Exception(result);

            return result;

        }


        public async Task<dynamic> RollBackReceivingConfirmationAsync(ProcessRequest payload)
        {
            //validar si ya fue confirmado antes - retorna sin procesarlo.
            _WEB curContext = new _WEB(this.Configuration);

            try
            {
                //Obtains the connection based on Customer Setup
                object[] erpConnection = UtilTool.ERP_GetConnection("SHIP_ERP_CONFIRM", payload.site, curContext.db);

                ConnectFactory erpFactory = ConnectFactory.GetConnectFactory(new WMSErpRequest
                {
                    curContext = curContext,
                    curConfig = erpConnection[0] as V2MasterConfig,
                    curErpCnn = erpConnection[1] as V2MasterConnection
                });


                WH_Obj curWMSObject = new WH_Obj
                {
                    SITE = payload.site,
                    DOCUMENT = payload.document,
                    USERNAME = payload.username,
                    payloadAction = payload.action
                };

                return erpFactory.ErpService().RollBackReceivingErp(curWMSObject);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
     
    }


}