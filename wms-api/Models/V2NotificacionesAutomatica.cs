using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2NotificacionesAutomatica
    {
        public int Rowid { get; set; }
        public string CodNotificacion { get; set; }
        public string Procedimiento { get; set; }
        public string Mto { get; set; }
        public short IndActivo { get; set; }
        public DateTime Fechacreacion { get; set; }
        public string Usuariocreacion { get; set; }
        public DateTime? LastExec { get; set; }
        public DateTime? NextExec { get; set; }
        public short? MinutosFreq { get; set; }
        public DateTime? Fechamod { get; set; }
        public string Usuariomod { get; set; }
    }
}
