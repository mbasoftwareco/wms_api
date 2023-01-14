using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2MasterMetalist
    {
        public int Rowid { get; set; }
        public string ClassCode { get; set; }
        public string MasterKey { get; set; }
        public string MasterValue { get; set; }
        public int Seq { get; set; }
        public DateTime Createdon { get; set; }
        public string Createdby { get; set; }
    }
}
