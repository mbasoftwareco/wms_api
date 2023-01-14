using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wms_api.Models;
using wms_api.Utils;
using wms_api.Wrappers;

namespace wms_api.ErpConnector.SAPB1
{
    public class SAPB1_Factory : ConnectFactory
    {          
        private WMSErpRequest curRequest { get; set; }

        public SAPB1_Factory(WMSErpRequest _erpRequest)
        {
            curRequest = _erpRequest; 
        }

        public override IErpService ErpService()
        {
            return new ErpService(curRequest);
        }


    }
}
