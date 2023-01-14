using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TTaskAssignSkip
    {
        public int Rowid { get; set; }
        public string Site { get; set; }
        public string Docid { get; set; }
        public string Item { get; set; }
        public int Skip { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
