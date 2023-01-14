using Microsoft.Extensions.Configuration;
using System.Data;
using System.Threading.Tasks;
using wms_api.Utils;
using wms_api.Wrappers;
using wms_api.Models;
using System.Linq;
using wms_api.DeliveryConnector;

namespace wms_api.Helpers
{
    public class DeliveryLocalHelper
    {

        // private WMS_LIGERO_LIVEContext db = new WMS_LIGERO_LIVEContext();

        private IConfiguration Configuration;
        private WMS_LIGERO_LIVEContext _db = new WMS_LIGERO_LIVEContext();

        public DeliveryLocalHelper() { }

        public DeliveryLocalHelper(IConfiguration _configuration)
        {
            this.Configuration = _configuration;
            this._db = new WMS_LIGERO_LIVEContext();
        }

        public async Task<dynamic> DeliveryLocalAction(ProcessRequest payload)
        {
            switch (payload.action)
            {
               
                case "DELIVERY_CONFIRM":
                    return "";

                case "DELIVERY_COMPLETED":
                    return ""; 

                default:
                    return DeliveryLocalExeAction(payload);
            }

        }
      
        /*
        public async Task<dynamic> ConfirmDelivery(ProcessRequest payload)
        {
            string company_code = "";
            string service_code = "";

            try
            {
                var data_captured = payload.data_captured.Split("-");
                company_code = data_captured[0].Trim();
                service_code = data_captured[1].Trim();
            }
            catch { }

            var _deliveryCompany = await Task.Run(() => this._db.V2WmsDeliveryCompanies.SingleOrDefault(x => x.CompanyCode == company_code));
            var _deliveryService = await Task.Run(() => this._db.V2MasterDeliveryServices.SingleOrDefault(x => x.CompanyCode == company_code && x.ServiceCode == service_code));

           DataSet ds = (new _WEB(this.Configuration)).sp_Delivery(payload.action, new WH_Obj
            {
                USERNAME = payload.username,
                DOCUMENT = payload.document,
                SITE = payload.site
            });

            DeliveryFactory deliveryFactory = DeliveryFactory.GetDeliveryFactory(new WMSDeliveryRequest
            {
                curContext = new _WEB(this.Configuration),
                curDeliveryCompany = _deliveryCompany,
                curDeliveryService = _deliveryService
            });

            dynamic responseConfirm = null;

            //if (deliveryFactory != null)
            //    responseConfirm = await deliveryFactory.DeliveryService().CrearRemesaAsync(ds, payload);
            //else if (service_code == "MASIVO")
            //    responseConfirm = await crearRemesaOtros(ds, payload);


            return responseConfirm;

        }
        */

        public dynamic DeliveryLocalExeAction(ProcessRequest payload)
        {
            WH_Obj curWMSObject = new WH_Obj
            {
                USERNAME = payload.username,
                DOCUMENT = payload.document,
                SESSION_ID = payload.session_id,
                ID_PROCESS = payload.id_process,
                SITE = payload.site
            };

            return (new _WEB(this.Configuration)).sp_DeliveryLocal(payload.action, curWMSObject);
        }

    }
}
