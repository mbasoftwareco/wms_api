using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class PrydeVwStockAvailableByItem
    {
        public string Site { get; set; }
        public string Itemcode { get; set; }
        public decimal? QtyAvailable { get; set; }
        public decimal? StockQty { get; set; }
        public decimal? QtyOnPick { get; set; }
        public int QtyShipReserved { get; set; }
    }
}
