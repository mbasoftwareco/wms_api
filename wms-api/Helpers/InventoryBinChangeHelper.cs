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
    public class InventoryHelper
    {

        private IConfiguration Configuration;
        private string CurrentUser;
        private WMS_LIGERO_LIVEContext _db = new WMS_LIGERO_LIVEContext();

        public InventoryHelper() { }

        public InventoryHelper(IConfiguration _configuration)
        {
            this.Configuration = _configuration;
            this._db = new WMS_LIGERO_LIVEContext();
        }

        public async Task<dynamic> Action(ProcessRequest payload)
        {
            //  payload.parameters HACER CAST CON  ProcessShippingRequest

            switch (payload.action)
            {
                case "BIN_CHANGE_LOG":
                    dynamic report = Get(payload);
                    return report;

                case "CONFIRM_BIN_CHANGE_ERP":
                    return await PostBinChangeConfirmationAsync(payload);

                default:
                    dynamic reportdft = Get(payload);
                    return reportdft;
            }

        }

        public async Task<dynamic> PostBinChangeConfirmationAsync(ProcessRequest payload, bool useThread = false, bool onlyPrepare = false)
        {

            _WEB curContext = new _WEB(this.Configuration);

            TBarcodeTrack opeDoc = curContext.db.TBarcodeTracks.FirstOrDefault(f => f.Rowid.ToString() == payload.document && f.Confirmdoc != null);

            //validar si ya fue confirmado antes - retorna sin procesarlo.
            if (opeDoc != null)
                return new WMSResponse<dynamic>("Process Completed OK! " + opeDoc.Confirmdoc);

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
                    guidSyncBatch = curContext.sp_InventoryBinChange("ERP_PREPARE_CONFIRM", curWMSObject).Tables[0].Rows[0][0].ToString();
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
                    curResponse = (await erpFactory.ErpService().ConfirmBinChangeErp(curWMSObject)).message;
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


        public dynamic Get(ProcessRequest payload)
        {
            WH_Obj curWMSObject = new WH_Obj
            {
                USERNAME = payload.username,
                DATA_CAPTURED = payload.data_captured,
                SITE = payload.site,
                DOCUMENT = payload.document
            };

            return (new _WEB(this.Configuration)).sp_InventoryBinChange(payload.action, curWMSObject);
        }



    }
}
