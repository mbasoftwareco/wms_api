using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class PrydeVwStockAvailableByItemLot
    {
        public string Site { get; set; }
        public string Itemcode { get; set; }
        public string Lotno { get; set; }
        public decimal? StockQty { get; set; }
        public decimal? QtyOnPick { get; set; }
        public decimal? QtyAvailable { get; set; }
    }
}
