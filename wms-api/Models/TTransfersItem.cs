using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TTransfersItem
    {
        public int Rowid { get; set; }
        public string Docid { get; set; }
        public string SiteOri { get; set; }
        public string SiteDest { get; set; }
        public string Itemcode { get; set; }
        public string Itemname { get; set; }
        public string Uom { get; set; }
        public string Lot { get; set; }
        public double Quantity { get; set; }
        public double QuantityRemoved { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Removedby { get; set; }
        public DateTime? Removedon { get; set; }
        public string Sessionid { get; set; }
    }
}
