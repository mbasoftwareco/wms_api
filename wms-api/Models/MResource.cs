using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class MResource
    {
        public MResource()
        {
            MResourcesRuntimes = new HashSet<MResourcesRuntime>();
        }

        public int Rowid { get; set; }
        public string ResourceType { get; set; }
        public string ResourceName { get; set; }
        public string ResourceAddress { get; set; }
        public int? Selected { get; set; }
        public string Site { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<MResourcesRuntime> MResourcesRuntimes { get; set; }
    }
}
