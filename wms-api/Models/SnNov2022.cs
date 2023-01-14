using System;
using System.Collections.Generic;

#nullable disable

namespace wms_api.Models
{
    public partial class SnNov2022
    {
        public string NúmeroDeArtículo { get; set; }
        public string CódigoDeAlmacén { get; set; }
        public double? Cantidad { get; set; }
        public double? MdAbsEntry { get; set; }
        public string NúmeroDeSerieDelFabricante { get; set; }
    }
}
