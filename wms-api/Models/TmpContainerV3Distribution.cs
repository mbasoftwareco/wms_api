using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TmpContainerV3Distribution
    {
        public int RowId { get; set; }
        public int ExcelRowId { get; set; }
        public string Item { get; set; }
        public string Po { get; set; }
        public int Line { get; set; }
        public int Qty { get; set; }
        public int QtyToErp { get; set; }
        public string Xuid { get; set; }
        public DateTime Regdate { get; set; }
        public string Step { get; set; }
    }
}
