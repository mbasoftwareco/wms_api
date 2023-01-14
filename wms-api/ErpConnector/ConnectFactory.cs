using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wms_api.Models;
using wms_api.Utils;
using wms_api.Wrappers;

namespace wms_api.ErpConnector
{
    public abstract class ConnectFactory
    {

        public abstract IErpService ErpService();
        public static ConnectFactory GetConnectFactory(WMSErpRequest _erpRequest)
        {

            switch (_erpRequest.curErpCnn.Type)
            {

                case Constantes.SAPB1:
                    return new SAPB1.SAPB1_Factory(_erpRequest);

                 case Constantes.SIESA:
                   return new SIESA.SIESA_Factory(_erpRequest);

            }

            return null;
        }
        
    }

    public interface IErpService
    {
        Task<dynamic> ConfirmBinChangeErp(WH_Obj curWMSObject);
        Task<dynamic> RollBackBinChangeErp(WH_Obj curWMSObject);

        Task<dynamic> ConfirmShippingErp(WH_Obj curWMSObject);
        Task<dynamic> RollBackShippingErp(WH_Obj curWMSObject);

        Task<dynamic> ConfirmReceivingErp(WH_Obj curWMSObject);
        Task<dynamic> RollBackReceivingErp(WH_Obj curWMSObject);
        
    }

}
