using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using wms_api.Utils;
using wms_api.Wrappers;
using WSUNOEEServiceReference;

namespace wms_api.ErpConnector.SIESA
{
    public class ErpService : IErpService
    {

        private static WMSErpRequest curRequest { get; set; }

        public ErpService(WMSErpRequest _curRequest)
        {
            curRequest = _curRequest;
        }


        #region :: CLASES XML

        [XmlRoot(ElementName = "Importar")]
        public class Importar
        {

            [XmlElement(ElementName = "NombreConexion")]
            public string NombreConexion { get; set; }

            [XmlElement(ElementName = "IdCia")]
            public string IdCia { get; set; }

            [XmlElement(ElementName = "Usuario")]
            public string Usuario { get; set; }

            [XmlElement(ElementName = "Clave")]
            public string Clave { get; set; }

            [XmlElement(ElementName = "Datos")]
            public Datos Datos { get; set; }
        }

        [XmlRoot(ElementName = "Datos")]
        public class Datos
        {

            [XmlElement(ElementName = "Linea")]
            public List<string> Linea { get; set; }
        }

        #endregion


        public async Task<dynamic> IntegrationErpWS(WH_Obj curWMSObject, string id_process)
        {

            DataSet ds = null;

            if (id_process == "SHIPPING")
                ds = curRequest.curContext.sp_Shipping(curWMSObject.payloadAction, curWMSObject);

            else if (id_process == "RECEIVING")
                ds = curRequest.curContext.sp_Receiving(curWMSObject.payloadAction, curWMSObject);

            else if (id_process == "INVENTORY")
                ds = curRequest.curContext.sp_InventoryBinChange(curWMSObject.payloadAction, curWMSObject);


            #region :: CONNECTION 

            var dsParams = UtilTool.GetDynamicFromJSON(curRequest.curConfig.Params);

            string errores = "";
            string wsERP_URL = dsParams["WS_ENDPOINT"].ToString();
            string username = dsParams["USERNAME"].ToString();
            string password = dsParams["PASSWORD"].ToString();
            string conexion = dsParams["NAME_CONEXION"].ToString();
            string id_cia = dsParams["ID_CIA"].ToString();


            #endregion


            #region :: XML 

            Importar plano = new Importar();
            plano.NombreConexion = conexion;
            plano.IdCia = id_cia;
            plano.Usuario = username;
            plano.Clave = password;

            Datos datos = new Datos();
            datos.Linea = new List<string>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                datos.Linea.Add(row[0].ToString());
            }

            plano.Datos = datos;



            XmlSerializer serializer = new XmlSerializer(plano.GetType());
            var planoXml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    serializer.Serialize(writer, plano);
                    planoXml = sww.ToString(); // Your XML
                }
            }

            #endregion


            ImportarXMLRequest req = new ImportarXMLRequest();
            req.pvstrDatos = planoXml;
            req.printTipoError = -1;

            WSUNOEESoapClient wsERP = new WSUNOEESoapClient(WSUNOEESoapClient.EndpointConfiguration.WSUNOEESoap, wsERP_URL);

            ImportarXMLResponse dsResult = await wsERP.ImportarXMLAsync(req);

            if (dsResult.ImportarXMLResult.Nodes.Count > 0)
            {
                foreach (var dr in dsResult.ImportarXMLResult.Nodes)
                {
                    if (string.IsNullOrEmpty(dr.Value))
                        continue;

                    errores += dr.Value;
                }
            }

            if (!string.IsNullOrEmpty(errores))
                throw new Exception(errores);

            try
            {
                if (id_process == "SHIPPING")
                    curRequest.curContext.sp_Shipping("ERP_VALIDATE_CONFIRM", curWMSObject);

                else if (id_process == "RECEIVING")
                    curRequest.curContext.sp_Receiving("ERP_VALIDATE_CONFIRM", curWMSObject);

                else if (id_process == "INVENTORY")
                    curRequest.curContext.sp_InventoryBinChange("ERP_VALIDATE_CONFIRM", curWMSObject);

            }
            catch { }

            //Retorna el mensaje de exito
            return new WMSResponse<dynamic>("Process Completed OK! " + curWMSObject.SESSION_ID);
        }


        public async Task<dynamic> IntegrationErpDB(WH_Obj curWMSObject, string id_process)
        {

            DataSet ds = null;

            if (id_process == "SHIPPING")
                ds = curRequest.curContext.sp_Shipping(curWMSObject.payloadAction, curWMSObject);

            else if (id_process == "RECEIVING")
                ds = curRequest.curContext.sp_Receiving(curWMSObject.payloadAction, curWMSObject);

            else if (id_process == "INVENTORY")
                ds = curRequest.curContext.sp_InventoryBinChange(curWMSObject.payloadAction, curWMSObject);



            #region :: CONNECTION 

            var dsParams = UtilTool.GetDynamicFromJSON(curRequest.curConfig.Params);


            string errores = "";
            string session = curWMSObject.SESSION_ID;
            string referencia = curWMSObject.SESSION_ID;
            string ruta_impodatos = dsParams["PATH"].ToString(); //@"\\192.168.10.98\SiesaEE\UnoEE\Utiles\ImpoDatos.exe";  
            string username = dsParams["USERNAME"].ToString();
            string password = dsParams["PASSWORD"].ToString();
            string conexion = dsParams["CONEXION"].ToString();
            string id_cia = dsParams["ID_CIA"].ToString();

            #endregion


            #region :: CALL IMPODATOS.EXE

            Process process = new Process();
            process.EnableRaisingEvents = true;

            if (!File.Exists(ruta_impodatos))
                throw new Exception($"Archivo {ruta_impodatos} no existe.");



            //1. Procedimiento que genera el plano de acuerdo a las condiciones

            //2. Ejecucion del llamado del WebServices de SIESA
            process.StartInfo.FileName = ruta_impodatos;

            string argumentos = $"1,{conexion},{username},{password},{id_cia},{session},{referencia},0";
            process.StartInfo.Arguments = argumentos;

            process.StartInfo.CreateNoWindow = true;
            process.Start();

            #endregion


            //3. Evaluacion de la Respuesta
            try
            {
                if (id_process == "SHIPPING")
                    curRequest.curContext.sp_Shipping("ERP_VALIDATE_CONFIRM", curWMSObject);

                else if (id_process == "RECEIVING")
                    curRequest.curContext.sp_Receiving("ERP_VALIDATE_CONFIRM", curWMSObject);

                else if (id_process == "INVENTORY")
                    curRequest.curContext.sp_InventoryBinChange("ERP_VALIDATE_CONFIRM", curWMSObject);
            }
            catch { }


            //Retorna el mensaje de exito
            return new WMSResponse<dynamic>("Process Completed OK! " + curWMSObject.SESSION_ID);

        }

        #region :: INVENTORY  BIN CHANGE ERP

        public async Task<dynamic> ConfirmBinChangeErp(WH_Obj curWMSObject)
        {

            if (UtilTool.GetParameter("ERP.INTEGRATION.MODE") == "DATABASE")
                return await IntegrationErpDB(curWMSObject, "INVENTORY");
            else
                return await IntegrationErpWS(curWMSObject, "INVENTORY");

        }

        public async Task<dynamic> RollBackBinChangeErp(WH_Obj curWMSObject)
        {
            //Retorna el mensaje de exito
            return new WMSResponse<dynamic>("Process Completed OK! " + curWMSObject.SESSION_ID);

        }

        #endregion


        #region :: SHIPPING 

        public async Task<dynamic> ConfirmShippingErp(WH_Obj curWMSObject)
        {

            if (UtilTool.GetParameter("ERP.INTEGRATION.MODE") == "DATABASE")
                return await IntegrationErpDB(curWMSObject, "SHIPPING");
            else
                return await IntegrationErpWS(curWMSObject, "SHIPPING");

        }

        public async Task<dynamic> RollBackShippingErp(WH_Obj curWMSObject)
        {

            //Retorna el mensaje de exito
            return new WMSResponse<dynamic>("Process Completed OK! " + curWMSObject.SESSION_ID);

        }

        #endregion


        #region :: RECEIVING 

        public async Task<dynamic> ConfirmReceivingErp(WH_Obj curWMSObject)
        {

            if (UtilTool.GetParameter("ERP.INTEGRATION.MODE") == "DATABASE")
                return await IntegrationErpDB(curWMSObject, "RECEIVING");
            else
                return await IntegrationErpWS(curWMSObject, "RECEIVING");

        }

        public async Task<dynamic> RollBackReceivingErp(WH_Obj curWMSObject)
        {
            return new WMSResponse<dynamic>("Process Completed OK! " + curWMSObject.SESSION_ID);
        }

        #endregion


    }
}
