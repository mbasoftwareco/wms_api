using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using wms_api.Models;
using wms_api.Utils;
using wms_api.Wrappers;

namespace wms_api.DeliveryConnector
{
    public abstract class DeliveryFactory
    {

        public abstract IDeliveryService DeliveryService();
        public static DeliveryFactory GetDeliveryFactory(WMSDeliveryRequest _devRequest)
        {

            switch (_devRequest.curDeliveryCompany.CompanyCode)
            {

                case Constantes.TCC:
                    return new TCC.TCC_Factory(_devRequest);

                case Constantes.TRANSPRENSA:
                    return new TRANSPRENSA.TRANSPRENSA_Factory(_devRequest);

                case Constantes.COORDINADORA:
                    return new COORDINADORA.COORDINADORA_Factory(_devRequest);

                case Constantes.DEPRISA:
                    return new DEPRISA.DEPRISA_Factory(_devRequest);

            }

            return null;
        }
    }

    public interface IDeliveryService
    {
        Task<dynamic> CotizarRemesaAsync(DataSet ds, ProcessRequest payload);
        Task<dynamic> CrearRemesaAsync(DataSet ds, ProcessRequest payload);
        Task<dynamic> ConsultarRemesaAsync(DataSet ds);        
    }

}
