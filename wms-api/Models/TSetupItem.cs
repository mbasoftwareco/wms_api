using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TSetupItem
    {
        public int Rowid { get; set; }
        public string Itemcode { get; set; }
        public string Site { get; set; }
        public string BinAssigned { get; set; }
        public DateTime? LastCount { get; set; }
        public string CountType { get; set; }
    }
}
