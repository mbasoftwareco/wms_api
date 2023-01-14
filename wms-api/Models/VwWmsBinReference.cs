using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwWmsBinReference
    {
        public string Site { get; set; }
        public string Bincode { get; set; }
        public string Item { get; set; }
        public DateTime? Receivedon { get; set; }
        public double? BinSequence { get; set; }
    }
}
