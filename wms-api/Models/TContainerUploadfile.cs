using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TContainerUploadfile
    {
        public int Rowid { get; set; }
        public string FileName { get; set; }
        public DateTime RegDate { get; set; }
        public string Xuid { get; set; }
        public string CustId { get; set; }
        public string Brand { get; set; }
        public string Wh { get; set; }
        public string Sonumber { get; set; }
        public string CustomerRef { get; set; }
        public string Po { get; set; }
        public string Invoice { get; set; }
        public string InvoiceDate { get; set; }
        public string InvoicePeriod { get; set; }
        public string StyleNo { get; set; }
        public string Description { get; set; }
        public string Eancode { get; set; }
        public double? Qty { get; set; }
        public string Value { get; set; }
        public string ShipNo { get; set; }
        public string Container { get; set; }
        public string ShippedVia { get; set; }
        public string CreatedBy { get; set; }
    }
}
