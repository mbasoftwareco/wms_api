using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using wms_api.Utils;
using wms_api.Wrappers;

namespace wms_api.Helpers
{
    public class DataCaptureHelper
    {

        private IConfiguration Configuration;
        private string CurrentUser;

        public DataCaptureHelper() { }

        public DataCaptureHelper(IConfiguration _configuration)
        {
            this.Configuration = _configuration;
        }

        public async Task<dynamic> Action(ProcessRequest payload)
        {
            //  payload.parameters HACER CAST CON  ProcessShippingRequest
            dynamic data = GetSteps(payload);
            return data; 

        }


        public dynamic GetSteps(ProcessRequest payload)
        {
            WH_Obj curWMSObject = new WH_Obj
            {
                USERNAME = payload.username,
                DOCUMENT = payload.document,
                SITE = payload.site,
                DATA_CAPTURED =  payload.data_captured,
                STEP = payload.step,
                ID_PROCESS = payload.id_process,
                SESSION_ID = payload.session_id,
               
            };

            return (new _WEB(this.Configuration)).sp_DataCapture(payload.action, curWMSObject);
        }

         


    }
}
