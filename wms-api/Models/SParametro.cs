using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class SParametro
    {
        public int Rowid { get; set; }
        public int? RowidEmpresa { get; set; }
        public string Tiporeg { get; set; }
        public string CodParametro { get; set; }
        public string NombreParametro { get; set; }
        public string ValorParametro { get; set; }
    }
}
