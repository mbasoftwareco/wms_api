using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wms_api.Wrappers.Transportadoras
{

    public class WMSQuoteResponse
    {
        public double FreightValue { get; set; }
        public double DeclaredtValue { get; set; }
        public bool Success { get; set; }
        public string Msg { get; set; }
    }
     
}
