using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class ZSite
    {
        public int? Rowid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNo { get; set; }
        public string County { get; set; }
        public int Selected { get; set; }
    }
}
