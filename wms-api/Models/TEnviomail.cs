using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class TEnviomail
    {
        public int Rowid { get; set; }
        public int RowidEmpresa { get; set; }
        public string Mto { get; set; }
        public string Mfrom { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Usuariocreacion { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public int? Sent { get; set; }
        public short UseBcc { get; set; }
        public DateTime? Fechaenviado { get; set; }
        public string Observaciones { get; set; }
        public string Attachment { get; set; }
    }
}
