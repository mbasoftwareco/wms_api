using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class SUsuariosEntidade
    {
        public int Rowid { get; set; }
        public int RowidEmpresa { get; set; }
        public int? ErpIdCia { get; set; }
        public string IdTipoEntidad { get; set; }
        public string ValorEntidad { get; set; }
        public int RowidUsuario { get; set; }
        public bool IndPrincipal { get; set; }
        public DateTime Fechacreacion { get; set; }
        public string Usuariocreacion { get; set; }
        public DateTime? Fechamod { get; set; }
        public string Usuariomod { get; set; }

        public virtual MEmpresa RowidEmpresaNavigation { get; set; }
        public virtual SUsuario RowidUsuarioNavigation { get; set; }
    }
}
