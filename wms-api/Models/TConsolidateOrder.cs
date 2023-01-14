using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TConsolidateOrder
    {
        public int Rowid { get; set; }
        public string ConsolidateNo { get; set; }
        public string Type { get; set; }
        public string Erpdoc { get; set; }
        public string Accountname { get; set; }
        public string Accountid { get; set; }
        public string Pickingdoc { get; set; }
        public string Packingdoc { get; set; }
        public DateTime? Packingdate { get; set; }
        public int Statusid { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Removedby { get; set; }
        public DateTime? Removedon { get; set; }
        public string Sessionid { get; set; }
        public bool IndPrincipal { get; set; }
    }
}
