using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wms_api.Wrappers.Transportadoras
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Despacho
    {
        public string clave { get; set; }
        public int unidadnegocio { get; set; }
        public string fechadespacho { get; set; }
        public string cuentaremitente { get; set; }
        public string tipoidentificacionremitente { get; set; }
        public string razonsocialremitente { get; set; }
        public string ciudadorigen { get; set; }
        public string tipoidentificaciondestinatario { get; set; }
        public string identificaciondestinatario { get; set; }
        public string razonsocialdestinatario { get; set; }
        public string direcciondestinatario { get; set; }
        public string ciudaddestinatario { get; set; }
        public string telefonodestinatario { get; set; }
        public string direccionremitente { get; set; }
        public string telefonoremitente { get; set; }
        public string generarDocumentos { get; set; }
        public string totalpeso { get; set; }
        public string totalvalormercancia { get; set; }
        public List<Unidad> unidad { get; set; }
        public List<Documentoreferencium> documentoreferencia { get; set; }
        public List<Solicitudrecogida> solicitudrecogida { get; set; }
    }

    public class Documentoreferencium
    {
        public string tipodocumento { get; set; }
        public string numerodocumento { get; set; }
        public string fechadocumento { get; set; }
    }

    public class Unidad
    {
        public string tipounidad { get; set; }
        public string cantidadunidades { get; set; }
        public object kilosreales { get; set; }
        public object pesovolumen { get; set; }
        public object valormercancia { get; set; }
        public string largo { get; set; }
        public string alto { get; set; }
        public string ancho { get; set; }

    }

    public class TCCRemesa
    {
        public Despacho despacho { get; set; }
    }

    public class TCCRemesaResponse
    {
        [JsonProperty("@cdata-section-elements")]
        public string CdataSectionElements { get; set; }
        public string remesa { get; set; }
        public string numerorecogida { get; set; }
        public string urlrelacionenvio { get; set; }
        public string urlremesa { get; set; }
        public string urlrotulos { get; set; }
        public string respuesta { get; set; }
        public string mensaje { get; set; }
    }

    public class Solicitudrecogida
    {
        public string fecha { get; set; }
        public string ventanainicio { get; set; }
        public string ventanafin { get; set; }
    }

}
