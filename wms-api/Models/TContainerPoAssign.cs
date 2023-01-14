using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TContainerPoAssign
    {
        public int Rowid { get; set; }
        public string ContainerNo { get; set; }
        public string Po { get; set; }
        public string Item { get; set; }
        public int Lineid { get; set; }
        public int Qty { get; set; }
        public DateTime RegDate { get; set; }
        public string Username { get; set; }
        public string ErpUid { get; set; }
        public DateTime? ErpProcess { get; set; }
    }
}
