using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2WmsManualDeliveryCompany
    {
        public int Rowid { get; set; }
        public string Company { get; set; }
        public short IndActivo { get; set; }
    }
}
