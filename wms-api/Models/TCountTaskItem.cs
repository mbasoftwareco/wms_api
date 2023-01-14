using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TCountTaskItem
    {
        public int Rowid { get; set; }
        public string Site { get; set; }
        public string Tasknumber { get; set; }
        public string Bincode { get; set; }
        public string Itemcode { get; set; }
        public string Itemdesc { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }

        public virtual TCountTask TasknumberNavigation { get; set; }
    }
}
