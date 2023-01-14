using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwWmsPackingBalanceNotPacked
    {
        public string Site { get; set; }
        public string Erpdoc { get; set; }
        public int? Rowid { get; set; }
        public string Itemcode { get; set; }
        public string Itemname { get; set; }
        public double QtyPicking { get; set; }
        public double? QtyPackage { get; set; }
        public double? QtyPacked { get; set; }
        public string Confirmdoc { get; set; }
    }
}
