using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2OpeResource
    {
        public int Rowid { get; set; }
        public int? ProcessId { get; set; }
        public int? EntityType { get; set; }
        public string EntityRowid { get; set; }
    }
}
