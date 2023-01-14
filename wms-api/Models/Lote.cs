using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class Lote
    {
        public string Item { get; set; }
        public string Description { get; set; }
        public string Lote1 { get; set; }
        public string Bodega { get; set; }
        public double? Cantidad { get; set; }
        public DateTime Regdate { get; set; }
    }
}
