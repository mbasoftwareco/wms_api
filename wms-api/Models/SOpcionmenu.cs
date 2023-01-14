using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class SOpcionmenu
    {
        public SOpcionmenu()
        {
            InverseRowidOpcionpadreNavigation = new HashSet<SOpcionmenu>();
            SRolesOpcionmenus = new HashSet<SRolesOpcionmenu>();
        }

        public int Rowid { get; set; }
        public int? RowidOpcionpadre { get; set; }
        public string NombreOpcion { get; set; }
        public short IndActivo { get; set; }
        public int Numorden { get; set; }
        public string UrlLink { get; set; }
        public string Icono { get; set; }
        public string TextoAyuda { get; set; }
        public DateTime Fechacreacion { get; set; }
        public string Usuariocreacion { get; set; }
        public DateTime? Fechamod { get; set; }
        public string Usuariomod { get; set; }
        public string TipoOpcion { get; set; }
        public string ModuloProceso { get; set; }

        public virtual SOpcionmenu RowidOpcionpadreNavigation { get; set; }
        public virtual ICollection<SOpcionmenu> InverseRowidOpcionpadreNavigation { get; set; }
        public virtual ICollection<SRolesOpcionmenu> SRolesOpcionmenus { get; set; }
    }
}
