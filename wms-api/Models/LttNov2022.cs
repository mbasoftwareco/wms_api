using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class LttNov2022
    {
        public string NúmeroDeArtículo { get; set; }
        public double? Cantidad { get; set; }
        public string CódigoDeAlmacén { get; set; }
        public string NúmeroDeLote { get; set; }
    }
}
