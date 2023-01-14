using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class LLogError
    {
        public int Rowid { get; set; }
        public string LogClass { get; set; }
        public string LogMessage { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Process { get; set; }
    }
}
