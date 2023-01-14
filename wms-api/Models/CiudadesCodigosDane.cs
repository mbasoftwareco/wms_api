using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class CiudadesCodigosDane
    {
        public double? Id { get; set; }
        public double? CodigoCiudad { get; set; }
        public string CodigoDane { get; set; }
        public string NombreCiudad { get; set; }
        public double? CodigoDepartamento { get; set; }
        public string Departamento { get; set; }
        public DateTime? Fecha { get; set; }
        public string F8 { get; set; }
        public string CodigoDane1 { get; set; }
        public string F10 { get; set; }
    }
}
