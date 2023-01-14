using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TmpErpdocStock
    {
        public string Erpdoc { get; set; }
        public int Stock { get; set; }
        public DateTime Regdate { get; set; }
    }
}
