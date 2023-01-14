using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TInventoryTrack
    {
        public int Rowid { get; set; }
        public string Confirmdoc { get; set; }
        public string Process { get; set; }
        public long? Barcode { get; set; }
        public string Company { get; set; }
        public string Site { get; set; }
        public string Itemcode { get; set; }
        public string Itemname { get; set; }
        public string Bincode { get; set; }
        public string Uom { get; set; }
        public string Lot { get; set; }
        public double Quantity { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Removedby { get; set; }
        public DateTime? Removedon { get; set; }
        public double? QtyRemovedby { get; set; }
        public string Sessionid { get; set; }
        public string Postedby { get; set; }
        public DateTime? Postedon { get; set; }
        public string ReasonCode { get; set; }
        public string Note { get; set; }
        public double StockErpAvailable { get; set; }
    }
}
