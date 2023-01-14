using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwStockAvailableByItemWmsBin
    {
        public string Site { get; set; }
        public string Bincode { get; set; }
        public string Itemcode { get; set; }
        public double? QtyAvailable { get; set; }
        public double Sequence { get; set; }
    }
}
