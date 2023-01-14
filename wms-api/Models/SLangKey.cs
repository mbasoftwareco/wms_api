using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class SLangKey
    {
        public int Rowid { get; set; }
        public string Module { get; set; }
        public string Key { get; set; }
        public string Lang { get; set; }
        public string Value { get; set; }
        public int Controller { get; set; }
        public int IndActivo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
