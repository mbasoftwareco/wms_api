using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class V2ApiSiesaConector
    {
        public int Rowid { get; set; }
        public int Tiporeg { get; set; }
        public int Subtipo { get; set; }
        public int Version { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Tipodato { get; set; }
        public string Observaciones { get; set; }
        public string Obligatorio { get; set; }
        public int Inicio { get; set; }
        public int Tamano { get; set; }
        public int Final { get; set; }
        public string ValorFijo { get; set; }
        public string ValorVariable { get; set; }
    }
}
