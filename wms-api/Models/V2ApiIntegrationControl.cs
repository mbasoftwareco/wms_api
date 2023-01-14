using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2ApiIntegrationControl
    {
        public int Rowid { get; set; }
        public string BatchGuid { get; set; }
        public string IntegrationType { get; set; }
        public string Process { get; set; }
        public string SetupCode { get; set; }
        public string Action { get; set; }
        public string Direction { get; set; }
        public string Site { get; set; }
        public string Docnumber { get; set; }
        public string Refnumber { get; set; }
        public string Notes { get; set; }
        public int? StatusId { get; set; }
        public string RequestData { get; set; }
        public string ResponseData { get; set; }
        public short AllowReversion { get; set; }
        public short AllowResend { get; set; }
        public DateTime Createdon { get; set; }
        public string Createdby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedby { get; set; }
    }
}
