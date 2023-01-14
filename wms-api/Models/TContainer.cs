using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TContainer
    {
        public TContainer()
        {
            TBarcodeContainers = new HashSet<TBarcodeContainer>();
            TContainerPos = new HashSet<TContainerPo>();
            TContainerRuntimes = new HashSet<TContainerRuntime>();
        }

        public int Rowid { get; set; }
        public string ContainerNo { get; set; }
        public string Reference { get; set; }
        public string Note { get; set; }
        public bool Lock { get; set; }
        public string Status { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public string Site { get; set; }
        public string VendorId { get; set; }

        public virtual ICollection<TBarcodeContainer> TBarcodeContainers { get; set; }
        public virtual ICollection<TContainerPo> TContainerPos { get; set; }
        public virtual ICollection<TContainerRuntime> TContainerRuntimes { get; set; }
    }
}
