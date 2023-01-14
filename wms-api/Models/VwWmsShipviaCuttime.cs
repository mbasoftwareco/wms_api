using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwWmsShipviaCuttime
    {
        public string ShipviaCode { get; set; }
        public string CutOperator { get; set; }
        public int AddDays { get; set; }
        public int CutTime { get; set; }
    }
}
