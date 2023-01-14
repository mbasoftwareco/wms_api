using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TConfirmationSeq
    {
        public int Rowid { get; set; }
        public string Process { get; set; }
        public string Prefix { get; set; }
        public int Nextseq { get; set; }
    }
}
