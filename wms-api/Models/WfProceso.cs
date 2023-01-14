using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class WfProceso
    {
        public WfProceso()
        {
            WfProcesoSteps = new HashSet<WfProcesoStep>();
        }

        public string IdProceso { get; set; }
        public string Title { get; set; }
        public string WbLog { get; set; }
        public string WbBalance { get; set; }
        public string WbInquiry { get; set; }
        public string WbDocList { get; set; }
        public string ConfirmQuestion { get; set; }
        public string ConfirmYes { get; set; }
        public string ConfirmNo { get; set; }
        public string AssignType { get; set; }
        public string BalanceConfirmAction { get; set; }
        public DateTime Credate { get; set; }

        public virtual ICollection<WfProcesoStep> WfProcesoSteps { get; set; }
    }
}
