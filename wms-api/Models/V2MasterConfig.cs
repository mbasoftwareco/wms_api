using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2MasterConfig
    {
        public int Rowid { get; set; }
        public string ConfigClass { get; set; }
        public string Site { get; set; }
        public string SetupCode { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public string UiControlList { get; set; }
        public string Params { get; set; }
        public short Status { get; set; }
        public DateTime Createdon { get; set; }
        public string Createdby { get; set; }
    }
}
