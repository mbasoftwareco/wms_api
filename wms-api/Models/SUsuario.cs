using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class SUsuario
    {
        public SUsuario()
        {
            SRolesUsuarios = new HashSet<SRolesUsuario>();
            SUsuariosEntidades = new HashSet<SUsuariosEntidade>();
        }

        public int Rowid { get; set; }
        public int RowidEmpresa { get; set; }
        public string Identificacion { get; set; }
        public string ErpCodigo { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public short? IndCambiarclave { get; set; }
        public DateTime? AceptoCondiciones { get; set; }
        public short IndActivo { get; set; }
        public int? IdCia { get; set; }
        public string Idioma { get; set; }
        public DateTime Fechacreacion { get; set; }
        public string Usuariocreacion { get; set; }
        public DateTime? Fechamod { get; set; }
        public string Usuariomod { get; set; }
        public string UrlAvatar { get; set; }
        public string ResetToken { get; set; }

        public virtual ICollection<SRolesUsuario> SRolesUsuarios { get; set; }
        public virtual ICollection<SUsuariosEntidade> SUsuariosEntidades { get; set; }
    }
}
