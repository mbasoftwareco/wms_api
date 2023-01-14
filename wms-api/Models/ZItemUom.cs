using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class ZItemUom
    {
        public string Item { get; set; }
        public string Uom { get; set; }
        public decimal? Qtybase { get; set; }
        public decimal? Weight { get; set; }
    }
}
