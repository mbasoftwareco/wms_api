using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wms_api.Wrappers.Transportadoras
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    public class Destinatario
    {
        public string DestinatarioCodigo { get; set; }
        public string TipoDocumentoDestinatarioCodigo { get; set; }
        public string DestinatarioDocumento { get; set; }
        public string DestinatarioNombre { get; set; }
        public string DestinatarioDireccion { get; set; }
        public string DestinatarioTelefono { get; set; }
        public string DestinatarioCiudadCodigo { get; set; }
    } 

    public class Detalle
    {
        public string DetallePeso { get; set; }
        public string DetalleVolumen { get; set; }
        public string DetalleValorDeclarado { get; set; }
        public string DetalleProductoCodigo { get; set; }
        public string DetalleCantidad { get; set; }
        public string DetalleDescripcion { get; set; }
    }

    public class Remitente
    {
        public string RemitenteCodigo { get; set; }
        public string TipoDocumentoRemitenteCodigo { get; set; }
        public string RemitenteDocumento { get; set; }
        public string RemitenteNombre { get; set; }
        public string RemitenteDireccion { get; set; }
        public string RemitenteTelefono { get; set; }
        public string RemitenteCiudadCodigo { get; set; }
    }

    public class TransprensaRemesa
    {
        public string CiudadCodigoOrigen { get; set; }
        public string CiudadCodigoDestino { get; set; }
        public string TipoServicio { get; set; }
        public Remitente remitente { get; set; }
        public Destinatario destinatario { get; set; }
        public List<Detalle> detalle { get; set; }
        public string CentroCosto { get; set; }
        public string OrdenCarga { get; set; }
        public string OrdenCompra { get; set; }
        public string DocumentoCliente { get; set; }
        public string RemesaObservacion { get; set; }
        public string RemesaCodigo { get; set; }
        public string FormaPago { get; set; }
        public string OtrosValores { get; set; }
    }


    /* Quote */
    public class Data
    {
        public string CiudadOrigen { get; set; }
        public string CiudadDestino { get; set; }
        public string Peso { get; set; }
        public string Alto { get; set; }
        public string Largo { get; set; }
        public string Ancho { get; set; }
        public double ValorFlete { get; set; }
        public double ValorDeclarado { get; set; }
        public TipoDeViaje TipoDeViaje { get; set; }


        // CREAR REMESA
        public string Orden { get; set; }
        public string Remesa { get; set; }
        public string Validacion { get; set; }
        public bool Success { get; set; }
    }

    public class TransprensaQuote
    {
        public bool Success { get; set; }
        public Data Data { get; set; }
        public string Msg { get; set; }
    }

    public class TransprensaConfirm
    {
        public bool Success { get; set; }
        public List<Data> Data { get; set; }
        public string Msg { get; set; }
    }


    public class TipoDeViaje
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
    }


    public class Datum
    {
        public string remesa { get; set; }
        public string rotulo { get; set; }
    }

    public class TransprensaRotulos
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
        public List<Datum> Data { get; set; }
    }


}
