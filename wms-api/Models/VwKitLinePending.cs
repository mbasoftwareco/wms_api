using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwKitLinePending
    {
        public int Rowid { get; set; }
        public string Docid { get; set; }
        public string ItemcodeKit { get; set; }
        public string ItemcodeComponent { get; set; }
        public string ItemnameComponent { get; set; }
        public double FormulaQty { get; set; }
        public int QtyRequired { get; set; }
        public int QtyInStock { get; set; }
        public double QtyToPick { get; set; }
    }
}
