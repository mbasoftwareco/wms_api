using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2MasterDeliveryCity
    {
        public int Rowid { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string CodeTransprensa { get; set; }
        public string CodeTcc { get; set; }
        public string CodeDane { get; set; }
    }
}
