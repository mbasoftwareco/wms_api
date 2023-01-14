using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TCountTaskPosted
    {
        public int Rowid { get; set; }
        public string Tasknumber { get; set; }
        public string Site { get; set; }
        public string Bincode { get; set; }
        public string Itemcode { get; set; }
        public string Itemdesc { get; set; }
        public string AdjType { get; set; }
        public string Lot { get; set; }
        public double QtyWms { get; set; }
        public double QtyErp { get; set; }
        public double QtyCount { get; set; }
        public double? Qtyadj { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Postedby { get; set; }
        public DateTime? Postedon { get; set; }

        public virtual TCountTask TasknumberNavigation { get; set; }
    }
}
