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
    public class IntegrationHelper
    {

        // private WMS_LIGERO_LIVEContext db = new WMS_LIGERO_LIVEContext();

        private IConfiguration Configuration;
        private string CurrentUser;

        private WMS_LIGERO_LIVEContext _db = new WMS_LIGERO_LIVEContext();

        public IntegrationHelper() { }

        public IntegrationHelper(IConfiguration _configuration)
        {
            this.Configuration = _configuration;
            this._db = new WMS_LIGERO_LIVEContext();

        }

        public async Task<dynamic> Action(ProcessRequest payload)
        {
            switch (payload.action)
            {
                default:
                    dynamic IntegrationList = GetIntegrationDefault(payload);
                    return IntegrationList;
            }

        }

        public dynamic GetIntegrationDefault(ProcessRequest payload)
        {
            WH_Obj curWMSObject = new WH_Obj
            {
                USERNAME = payload.username,
                DOCUMENT = payload.document,
                SITE = payload.site,
                DATA_CAPTURED = payload.data_captured
            };
            return (new _WEB(this.Configuration)).sp_Integration(payload.action, curWMSObject);
        }
    }
}