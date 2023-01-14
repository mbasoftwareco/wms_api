using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TmpErpdocStockItem
    {
        public string Erpdoc { get; set; }
        public int Stock { get; set; }
        public string Itemcode { get; set; }
        public DateTime Regdate { get; set; }
    }
}
