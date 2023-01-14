using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class VwUserByRol
    {
        public int Rowid { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string IdRol { get; set; }
        public string NombreRol { get; set; }
    }
}
