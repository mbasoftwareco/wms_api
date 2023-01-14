using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TSetupShipcutShipvium
    {
        public int Rowid { get; set; }
        public int? ShipcutCode { get; set; }
        public string ShipviaCode { get; set; }
        public string Createdby { get; set; }
        public DateTime Createdon { get; set; }
    }
}
