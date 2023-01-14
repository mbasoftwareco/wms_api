using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class ImLote
    {
        public double? _ { get; set; }
        public string Item { get; set; }
        public double? Cant { get; set; }
        public string Bodega { get; set; }
        public string Lote { get; set; }
    }
}
