using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TTransfer
    {
        public int Rowid { get; set; }
        public string Docid { get; set; }
        public string SiteOri { get; set; }
        public string SiteDest { get; set; }
        public string Note { get; set; }
        public int Statusid { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Sessionid { get; set; }
    }
}
