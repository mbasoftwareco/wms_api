using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TBarcodePickingToErp
    {
        public int Rowid { get; set; }
        public string Erpdoc { get; set; }
        public int Erpline { get; set; }
        public string Site { get; set; }
        public string Itemcode { get; set; }
        public string LotSnTrack { get; set; }
        public string LotSn { get; set; }
        public double Quantity { get; set; }
        public DateTime Regdate { get; set; }
        public string CreatedBy { get; set; }
        public string UserCustom1 { get; set; }
    }
}
