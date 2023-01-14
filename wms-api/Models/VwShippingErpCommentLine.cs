using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwShippingErpCommentLine
    {
        public string Docid { get; set; }
        public string Comment { get; set; }
        public byte Ppt { get; set; }
        public byte Ppl { get; set; }
        public DateTime Date { get; set; }
    }
}
