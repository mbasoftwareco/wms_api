using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class MResourcesRuntime
    {
        public int Rowid { get; set; }
        public string OwnerType { get; set; }
        public string OwnerRowid { get; set; }
        public string TempleteCode { get; set; }
        public int RowidResource { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual MResource RowidResourceNavigation { get; set; }
    }
}
