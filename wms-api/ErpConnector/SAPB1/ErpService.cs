using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using wms_api.Models;
using wms_api.Utils;
using wms_api.Wrappers;

namespace wms_api.ErpConnector.SAPB1
{
    public class ErpService : IErpService
    {

        private static WMSErpRequest curRequest { get; set; }

        public ErpService(WMSErpRequest _curRequest)
        {
            curRequest = _curRequest;
        }

        public async Task<dynamic> ConfirmShippingErp(WH_Obj curWMSObject)
        {

            string json = curRequest.curContext.sp_executeReader(curWMSObject.payloadAction, curWMSObject);
 
            //Llama el webhook del conector que confirma en el ERP
            //Facade - API, ERP-DIRECT
            /*
            RestClient apiClient = new RestClient(baseUrl: "https://multisync.nubenegocios.com/api/");
            apiClient.AddDefaultHeader("APIKeyID", "292C648B-D1EC-4494-BEEC-C353D7E1BD2C"); //CONFIRM
            */
            var dsParams = UtilTool.GetDynamicFromJSON(curRequest.curConfig.Params);

            RestClient apiClient = new RestClient(baseUrl: dsParams["URL"].ToString());

            string apikey = dsParams["APIKEY"].ToString();
            apiClient.AddDefaultHeader("APIKeyID", apikey);//CONFIRM
            apiClient.AddDefaultHeader("Content-Type", "application/json");

            RestRequest request = new RestRequest("WR_WebHook", Method.Post);

            if (!string.IsNullOrEmpty(json))
                request.AddStringBody(json, "application/json");

            request.RequestFormat = DataFormat.Json;

            RestResponse response = await apiClient.ExecuteAsync(request);

            bool hasError = false;

            //Si la respusta es OK - StatusCode = 200, 201, 204
            if (response.StatusCode != HttpStatusCode.InternalServerError)
            {
                dynamic svcResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
                curWMSObject.SESSION_ID = svcResponse;
                curWMSObject.DATA_CAPTURED = null;
            }
            else
            {
                hasError = true;

                curWMSObject.DATA_CAPTURED = response.Content.Replace("'", "");
            }

            //Actualiza la base de datos con la entrega de SAP o el error
            //CONFIRM_UPDATE
            curRequest.curContext.sp_Shipping(curWMSObject.payloadAction + "_UPDATE", curWMSObject);

            if (hasError)
                throw new Exception(curWMSObject.DATA_CAPTURED);            

            //Retorna el mensaje de exito
            return new WMSResponse<dynamic>("Process Completed OK! " + curWMSObject.SESSION_ID);

        }

        public async Task<dynamic> RollBackShippingErp(WH_Obj curWMSObject)
        {

            DataSet ds = curRequest.curContext.sp_Shipping(curWMSObject.payloadAction, curWMSObject);

            string json = ds.Tables[0].Rows[0][0].ToString();

            //Llama el webhook del conector que confirma en el ERP
            //Facade - API, ERP-DIRECT

            /*
            RestClient apiClient = new RestClient(baseUrl: "https://multisync.nubenegocios.com/api/");
            apiClient.AddDefaultHeader("APIKeyID", "292C648B-D1EC-0000-BEEC-C353D7E1BD2C"); //ROLLBACK
            */

            var dsParams = UtilTool.GetDynamicFromJSON(curRequest.curConfig.Params);

            RestClient apiClient = new RestClient(baseUrl: dsParams["URL"].ToString());

            string apikey = dsParams["APIKEY"].ToString();
            apiClient.AddDefaultHeader("APIKeyID", apikey); //ROLLBACK

            apiClient.AddDefaultHeader("Content-Type", "application/json");

            RestRequest request = new RestRequest("WR_WebHook", Method.Post);

            if (!string.IsNullOrEmpty(json))
                request.AddStringBody(json, "application/json");

            request.RequestFormat = DataFormat.Json;

            RestResponse response = await apiClient.ExecuteAsync(request);

            //Si la respusta es OK - StatusCode = 200, 201, 204
            if (response.StatusCode != HttpStatusCode.InternalServerError)
            {
                dynamic svcResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
                curWMSObject.DATA_CAPTURED = svcResponse; 
            }
            else
                curWMSObject.SESSION_ID = response.Content.Replace("'", "");

            //Actualiza la base de datos con la entrega de SAP o el error
            curRequest.curContext.sp_Shipping("ROLLBACK_UPDATE", curWMSObject);

            if (response.StatusCode == HttpStatusCode.InternalServerError)
                throw new Exception(response.Content);

            //Retorna el mensaje de exito
            return new WMSResponse<dynamic>("Process Completed OK! " + curWMSObject.SESSION_ID);

        }

        public async Task<dynamic> ConfirmReceivingErp(WH_Obj curWMSObject)
        {
            return new WMSResponse<dynamic>("Process Completed OK! " + curWMSObject.SESSION_ID);
        }

        public async Task<dynamic> RollBackReceivingErp(WH_Obj curWMSObject)
        {
            return new WMSResponse<dynamic>("Process Completed OK! " + curWMSObject.SESSION_ID);
        }

        public Task<dynamic> ConfirmBinChangeErp(WH_Obj curWMSObject)
        {
            throw new NotImplementedException();
        }

        public Task<dynamic> RollBackBinChangeErp(WH_Obj curWMSObject)
        {
            throw new NotImplementedException();
        }
    }
}
