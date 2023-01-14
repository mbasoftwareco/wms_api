using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class WfProcesoRuntime
    {
        public int Rowid { get; set; }
        public string IdProceso { get; set; }
        public int Step { get; set; }
        public string StepName { get; set; }
        public string StepAttribute { get; set; }
        public string SessionId { get; set; }
        public string DataCaptured { get; set; }
        public string DataKey1 { get; set; }
        public string DataKey2 { get; set; }
        public string DataKey3 { get; set; }
        public DateTime? DataDate1 { get; set; }
        public string RequireLotno { get; set; }
        public string LogNotes { get; set; }
        public string Username { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime? Processed { get; set; }
        public DateTime? ProcessedErp { get; set; }
    }
}
