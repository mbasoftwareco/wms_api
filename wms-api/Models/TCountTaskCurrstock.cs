using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TCountTaskCurrstock
    {
        public int Rowid { get; set; }
        public string Tasknumber { get; set; }
        public string Site { get; set; }
        public string Bincode { get; set; }
        public string Itemcode { get; set; }
        public double Qtystock { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }

        public virtual TCountTask TasknumberNavigation { get; set; }
    }
}
