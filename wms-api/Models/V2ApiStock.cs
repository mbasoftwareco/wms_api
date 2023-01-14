using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2ApiStock
    {
        public int Rowid { get; set; }
        public string Site { get; set; }
        public string Item { get; set; }
        public string LoteSn { get; set; }
        public int Qty { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Processdate { get; set; }
    }
}
