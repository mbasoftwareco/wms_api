using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class MKitDocument
    {
        public int Rowid { get; set; }
        public string Company { get; set; }
        public string Docid { get; set; }
        public string Site { get; set; }
        public string ItemcodeKit { get; set; }
        public double Quantity { get; set; }
        public string Notes { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Docstatus { get; set; }
    }
}
