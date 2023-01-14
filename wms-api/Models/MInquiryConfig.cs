using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class MInquiryConfig
    {
        public int Rowid { get; set; }
        public string Columns { get; set; }
        public string Width { get; set; }
        public string Align { get; set; }
    }
}
