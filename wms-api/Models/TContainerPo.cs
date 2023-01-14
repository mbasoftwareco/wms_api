using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TContainerPo
    {
        public int Rowid { get; set; }
        public string ContainerNo { get; set; }
        public string Erpdoc { get; set; }
        public bool Lock { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Removedby { get; set; }
        public DateTime? Removedon { get; set; }

        public virtual TContainer ContainerNoNavigation { get; set; }
    }
}
