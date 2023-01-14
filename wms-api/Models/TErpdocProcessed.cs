using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TErpdocProcessed
    {
        public int Rowid { get; set; }
        public string Company { get; set; }
        public string Site { get; set; }
        public string Erpdoc { get; set; }
        public int Erpdocline { get; set; }
        public string Uom { get; set; }
        public string Item { get; set; }
        public double Qty { get; set; }
        public double? Qtyonbase { get; set; }
        public string Lot { get; set; }
        public string Sessionid { get; set; }
        public string Receiptdoc { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Postedby { get; set; }
        public DateTime? Postedon { get; set; }
    }
}
