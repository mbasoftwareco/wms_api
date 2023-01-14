using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class PrydeVwItem
    {
        public string Itemcode { get; set; }
        public string Itemname { get; set; }
        public string Uom { get; set; }
        public int IsKit { get; set; }
        public int? Rowid { get; set; }
        public string Upc { get; set; }
        public string RequireLotno { get; set; }
        public string Profile { get; set; }
        public string Vendorid { get; set; }
    }
}
