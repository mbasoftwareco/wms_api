using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class MEmpresasConfig
    {
        public int Rowid { get; set; }
        public string IdTipoErp { get; set; }
        public int? RowidEmpresa { get; set; }
        public string Step { get; set; }
        public int? Secuencia { get; set; }
        public string Tiporeg { get; set; }
        public string Parametros { get; set; }
        public int IndActivo { get; set; }
        public DateTime Fechacreacion { get; set; }

        public virtual MEmpresa RowidEmpresaNavigation { get; set; }
    }
}
