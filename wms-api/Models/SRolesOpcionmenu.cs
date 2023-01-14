using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class SRolesOpcionmenu
    {
        public int Rowid { get; set; }
        public int? RowidEmpresa { get; set; }
        public int RowidRol { get; set; }
        public int RowidMenuopcion { get; set; }
        public short IndActivo { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public string Usuariocreacion { get; set; }
        public DateTime? Fechamod { get; set; }
        public string Usuariomod { get; set; }

        public virtual MEmpresa RowidEmpresaNavigation { get; set; }
        public virtual SOpcionmenu RowidMenuopcionNavigation { get; set; }
        public virtual SRole RowidRolNavigation { get; set; }
    }
}
