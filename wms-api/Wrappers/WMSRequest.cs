using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wms_api.Models;
using wms_api.Utils;

namespace wms_api.Wrappers
{
    public class WMSErpRequest
    {
        public V2MasterConfig curConfig { get; set; }
        public V2MasterConnection curErpCnn { get; set; }
        public _WEB curContext { get; set; }

    }

    public class WMSDeliveryRequest
    {
        public V2WmsDeliveryCompany curDeliveryCompany { get; set; }
        public V2MasterDeliveryService curDeliveryService { get; set; }
        public _WEB curContext { get; set; }

    }

}
