using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class MPrintTemplate
    {
        public int RowId { get; set; }
        public string Code { get; set; }
        public string Prefix { get; set; }
        public string Name { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public bool? IsPl { get; set; }
        public string Pltemplate { get; set; }
        public string Pldetail { get; set; }
        public bool? IsUnique { get; set; }
        public bool? IsVisible { get; set; }
        public int NumCopies { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
