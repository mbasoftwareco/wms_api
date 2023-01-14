using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwWmsNavComparison
    {
        public string Itemcode { get; set; }
        public string Itemname { get; set; }
        public double WmsOnhand { get; set; }
        public decimal? NavOnhand { get; set; }
        public double WmsPicked { get; set; }
        public decimal? NavToShip { get; set; }
        public decimal? NavToReceive { get; set; }
    }
}
