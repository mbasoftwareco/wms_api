using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TBarcodeHistory
    {
        public int Rowid { get; set; }
        public long Barcode { get; set; }
        public string Company { get; set; }
        public string Site { get; set; }
        public string Bincode { get; set; }
        public string Item { get; set; }
        public string Lot { get; set; }
        public double QuantityOriginal { get; set; }
        public double QuantityRemaining { get; set; }
        public string Erpdoc { get; set; }
        public int Erpdocline { get; set; }
        public string Receiptdoc { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Postedby { get; set; }
        public DateTime? Postedon { get; set; }
        public string Removedby { get; set; }
        public DateTime? Removedon { get; set; }
        public string Sessionid { get; set; }
        public string Cancelby { get; set; }
        public DateTime? Cancelon { get; set; }
        public short Disabled { get; set; }
        public short Printed { get; set; }
        public string PrintGuid { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string LastBincode { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
