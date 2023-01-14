using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TBarcodeTrack
    {
        public int Rowid { get; set; }
        public long Barcode { get; set; }
        public string Itemcode { get; set; }
        public string LotSn { get; set; }
        public string Action { get; set; }
        public string Site { get; set; }
        public string Bincode1 { get; set; }
        public string Bincode2 { get; set; }
        public string Erpdoc { get; set; }
        public int? Erpdocline { get; set; }
        public string Uom { get; set; }
        public double? Casepack { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Confirmdoc { get; set; }
        public string Postedby { get; set; }
        public DateTime? Postedon { get; set; }
    }
}
