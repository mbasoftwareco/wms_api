using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TCountTaskRuntime
    {
        public int Rowid { get; set; }
        public string Site { get; set; }
        public string Tasknumber { get; set; }
        public string Itemcode { get; set; }
        public string Bincode { get; set; }
        public long Barcode { get; set; }
        public string Lot { get; set; }
        public double QtyExpected { get; set; }
        public double QtyCount { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Removedby { get; set; }
        public DateTime? Removedon { get; set; }

        public virtual TCountTask TasknumberNavigation { get; set; }
    }
}
