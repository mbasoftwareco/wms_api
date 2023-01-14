using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wms_api.Wrappers.Transportadoras
{
     

    

    public class CoordinadoraQuote
    {
        public int flete_total { get; set; }
        public double flete_fijo { get; set; }
        public double flete_variable { get; set; }
        public double peso_liquidado { get; set; }
        public double otros_valores { get; set; }
        public int producto { get; set; }
        public int ubl { get; set; }
        public double volumen { get; set; }
        public double peso_real { get; set; }
        public int dias_entrega { get; set; }
    }

    public class CoordinadoraGuia
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public int id_remision { get; set; }
        public string codigo_remision { get; set; }
        public string pdf_guia { get; set; }
        public string url_terceros { get; set; }
        public string referencia { get; set; }

    }

}
