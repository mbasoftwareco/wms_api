using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwStockAvailableByItemBarcode
    {
        public string Site { get; set; }
        public string Itemcode { get; set; }
        public string Barcode { get; set; }
        public decimal? StockQty { get; set; }
        public int QtyOnPick { get; set; }
        public decimal? QtyAvailable { get; set; }
    }
}
