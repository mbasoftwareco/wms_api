using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class ImpormedicalStock
    {
        public int Rowid { get; set; }
        public string StockType { get; set; }
        public string WhsCode { get; set; }
        public string ItemCode { get; set; }
        public string MdAbsEntry { get; set; }
        public string MnfSerial { get; set; }
        public int? Quantity { get; set; }
        public DateTime Regdate { get; set; }
    }
}
