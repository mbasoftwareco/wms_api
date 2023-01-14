using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class MEmpresa
    {
        public MEmpresa()
        {
            MEmpresasConfigs = new HashSet<MEmpresasConfig>();
            SRolesOpcionmenus = new HashSet<SRolesOpcionmenu>();
            SRolesUsuarios = new HashSet<SRolesUsuario>();
            SUsuariosEntidades = new HashSet<SUsuariosEntidade>();
        }

        public int Rowid { get; set; }
        public string Identificacion { get; set; }
        public string Razonsocial { get; set; }
        public short IndActivo { get; set; }
        public string IdTipoErp { get; set; }
        public string Logo { get; set; }
        public DateTime Fechacreacion { get; set; }
        public string Usuariocreacion { get; set; }
        public DateTime? Fechamod { get; set; }
        public string Usuariomod { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string CodPostal { get; set; }

        public virtual ICollection<MEmpresasConfig> MEmpresasConfigs { get; set; }
        public virtual ICollection<SRolesOpcionmenu> SRolesOpcionmenus { get; set; }
        public virtual ICollection<SRolesUsuario> SRolesUsuarios { get; set; }
        public virtual ICollection<SUsuariosEntidade> SUsuariosEntidades { get; set; }
    }
}
