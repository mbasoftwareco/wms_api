using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class Seriale
    {
        public string NúmeroDeArtículo { get; set; }
        public string DescripciónDelArtículo { get; set; }
        public string NúmeroDeSerieDelFabricante { get; set; }
        public string FechaDeAdmisión { get; set; }
        public string CódigoDeAlmacén { get; set; }
        public string NombreDelAlmacén { get; set; }
        public string Estado { get; set; }
        public string Ubicación { get; set; }
    }
}
