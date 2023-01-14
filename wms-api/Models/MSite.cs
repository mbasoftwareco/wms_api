using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class MSite
    {
        public string Site { get; set; }
        public string SiteName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime Regdate { get; set; }
        public string Country { get; set; }
    }
}
