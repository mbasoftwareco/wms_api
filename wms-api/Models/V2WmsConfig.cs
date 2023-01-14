using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2WmsConfig
    {
        public int Rowid { get; set; }
        public string ProcessId { get; set; }
        public string SetupCode { get; set; }
        public string EnSetupName { get; set; }
        public string EsSetupName { get; set; }
        public string Notes { get; set; }
        public string UiControl { get; set; }
        public short IndSiteLevel { get; set; }
        public short IndCustomerLevel { get; set; }
        public short IndUserLevel { get; set; }
    }
}
