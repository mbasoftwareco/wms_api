using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class WfProcesoStep
    {
        public int Rowid { get; set; }
        public string IdProceso { get; set; }
        public int Step { get; set; }
        public string LblRequest { get; set; }
        public string LblHelp { get; set; }
        public string Control { get; set; }
        public string Attribute { get; set; }
        public string Validate { get; set; }
        public string AutoInput { get; set; }
        public string ListOption { get; set; }
        public int StepEscape { get; set; }
        public int IndActivo { get; set; }
        public int MultiStep { get; set; }
        public int IsLastStep { get; set; }
        public DateTime Fechacreacion { get; set; }
        public string Usuariocreacion { get; set; }
        public DateTime? Fechamod { get; set; }
        public string Usuariomod { get; set; }
        public string LblAfterComplete { get; set; }
        public string StepFeatures { get; set; }
        public string Color { get; set; }

        public virtual WfProceso IdProcesoNavigation { get; set; }
    }
}
