using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwContainerFileLine
    {
        public string Po { get; set; }
        public string StyleNo { get; set; }
        public double? Qty { get; set; }
        public string ShipNo { get; set; }
        public double QtyPending { get; set; }
        public int QtyToReceive { get; set; }
        public double QtyOnProcess { get; set; }
        public string Description { get; set; }
        public string CustId { get; set; }
        public int Rowid { get; set; }
        public string Invoice { get; set; }
    }
}
