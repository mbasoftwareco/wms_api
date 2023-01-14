using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class SRolesUsuario
    {
        public int Rowid { get; set; }
        public int RowidEmpresa { get; set; }
        public int RowidUsuario { get; set; }
        public int RowidRol { get; set; }
        public DateTime Fechacreacion { get; set; }
        public string Usuariocreacion { get; set; }
        public DateTime? Fechamod { get; set; }
        public string Usuariomod { get; set; }

        public virtual MEmpresa RowidEmpresaNavigation { get; set; }
        public virtual SRole RowidRolNavigation { get; set; }
        public virtual SUsuario RowidUsuarioNavigation { get; set; }
    }
}
