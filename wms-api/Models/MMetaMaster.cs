using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class MMetaMaster
    {
        public int Rowid { get; set; }
        public string ClassCode { get; set; }
        public string MasterCode { get; set; }
        public string MasterName { get; set; }
        public int Seq { get; set; }
    }
}
