using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class SRole
    {
        public SRole()
        {
            SRolesOpcionmenus = new HashSet<SRolesOpcionmenu>();
            SRolesUsuarios = new HashSet<SRolesUsuario>();
        }

        public int Rowid { get; set; }
        public decimal? RowidTercero { get; set; }
        public string IdRol { get; set; }
        public string NombreRol { get; set; }
        public short? IndControltotal { get; set; }
        public short? IndTodosLosClientes { get; set; }
        public short IndTodasLasBodegas { get; set; }
        public int IndManejaTareas { get; set; }
        public int? Selected { get; set; }
        public DateTime Fechacreacion { get; set; }
        public string Usuariocreacion { get; set; }
        public DateTime? Fechamod { get; set; }
        public string Usuariomod { get; set; }

        public virtual ICollection<SRolesOpcionmenu> SRolesOpcionmenus { get; set; }
        public virtual ICollection<SRolesUsuario> SRolesUsuarios { get; set; }
    }
}
