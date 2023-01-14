using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2MasterConnection
    {
        public V2MasterConnection()
        {
            V2MasterDeliveryServiceRowidPrinterPackinglistNavigations = new HashSet<V2MasterDeliveryService>();
            V2MasterDeliveryServiceRowidPrinterPkglabelsNavigations = new HashSet<V2MasterDeliveryService>();
        }

        public int Rowid { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Cnnstring { get; set; }
        public string Site { get; set; }

        public virtual ICollection<V2MasterDeliveryService> V2MasterDeliveryServiceRowidPrinterPackinglistNavigations { get; set; }
        public virtual ICollection<V2MasterDeliveryService> V2MasterDeliveryServiceRowidPrinterPkglabelsNavigations { get; set; }
    }
}
