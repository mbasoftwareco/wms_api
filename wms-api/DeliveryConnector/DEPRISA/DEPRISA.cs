using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using wms_api.Models;
using wms_api.Utils;
using wms_api.Wrappers;
using wms_api.Wrappers.Transportadoras;

namespace wms_api.DeliveryConnector.DEPRISA
{
    public class DEPRISA_Factory : DeliveryFactory
    {
        private WMSDeliveryRequest curRequest { get; set; }

        public DEPRISA_Factory(WMSDeliveryRequest _devRequest)
        {
            curRequest = _devRequest;
        }

        public override IDeliveryService DeliveryService()
        {
            return new DeliveryService(curRequest);
        }

    }
}