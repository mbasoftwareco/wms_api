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
    public class ReportHelper
    {

        private IConfiguration Configuration;
        private string CurrentUser;

        public ReportHelper() { }

        public ReportHelper(IConfiguration _configuration)
        {
            this.Configuration = _configuration;
        }

        public async Task<dynamic> ReportAction(ProcessRequest payload)
        {
            //  payload.parameters HACER CAST CON  ProcessShippingRequest

            switch (payload.action)
            {
                case "LIST":
                    dynamic report = GetReport(payload);
                    return report;

                case "DOCUMENT":
                    return GetDocument(payload);

                default: return null;
            }

        }


        public async Task<dynamic> GetReport(ProcessRequest payload)
        {
            WH_Obj curWMSObject = new WH_Obj
            {
                USERNAME = payload.username,
                DOCUMENT = payload.document,
                SITE = payload.site,
                SESSION_ID = payload.session_id,
                DATA_CAPTURED = payload.data_captured
            };

            return (new _WEB(this.Configuration)).sp_Report(payload.action, curWMSObject);
        }


        public dynamic GetDocument(ProcessRequest payload)
        {
            WH_Obj curWMSObject = new WH_Obj
            {
                USERNAME = payload.username,
                DOCUMENT = payload.document,
                SITE = payload.site,
                SESSION_ID = payload.session_id,
                DATA_CAPTURED = payload.data_captured
            };

            return (new _WEB(this.Configuration)).sp_Report(payload.action, curWMSObject);
        }


    }
}
