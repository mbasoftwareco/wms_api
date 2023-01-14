using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using wms_api.Utils;
using wms_api.Models;
using wms_api.Wrappers;
using wms_api.Wrappers.Transportadoras;

namespace wms_api.DeliveryConnector.TCC
{
    public class DeliveryService : IDeliveryService
    {

        private static WMSDeliveryRequest curRequest { get; set; }

        private dynamic config { get; set; }

        public DeliveryService(WMSDeliveryRequest _curRequest)
        {
            curRequest = _curRequest;

            config = UtilTool.GetDynamicFromJSON(curRequest.curDeliveryService.SetupAttibutesValue);
        }


        public async Task<dynamic> CrearRemesaAsync(DataSet ds, ProcessRequest payload)
        {
            string endpoint = curRequest.curDeliveryCompany.GuideEndpoint;

            dynamic config = UtilTool.GetDynamicFromJSON(curRequest.curDeliveryService.SetupAttibutesValue);

            var client = new RestClient();

            var request = new RestRequest(endpoint, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            TCCRemesa remesa = new TCCRemesa();
            remesa.despacho = new Despacho();

            string sendername = config["sendername"];

            string sendercity = config["sendercity"];

            string senderaddress = config["senderaddress"];

            string senderphone = config["senderphone"];

            string valorxcaja = config["valorxcaja"];

            string generarDocumentos = config["generarDocumentos"];

            int valor = 0;

            int totalpeso = 0;

            int totalvalorproducto = 0;

            //remesa.despacho.clave = "CLIENTETCC608W3A61CJ";
            remesa.despacho.clave = curRequest.curDeliveryCompany.AccountPassword;

            remesa.despacho.solicitudrecogida = new List<Solicitudrecogida>();

            remesa.despacho.solicitudrecogida.Add(new Solicitudrecogida
            {
                fecha = DateTime.Now.ToString("yyyy-MM-dd"),
                ventanainicio = DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss"),
                ventanafin = DateTime.Now.AddDays(1).ToString("yyyy-MM-ddThh:mm:ss")
            });

            remesa.despacho.unidadnegocio = 1;
            remesa.despacho.fechadespacho = DateTime.Now.ToString("yyyy-MM-dd");
            remesa.despacho.cuentaremitente = curRequest.curDeliveryCompany.AccountUsername;
            remesa.despacho.tipoidentificacionremitente = "";
            remesa.despacho.razonsocialremitente = sendername;
            remesa.despacho.ciudadorigen = sendercity;
            remesa.despacho.tipoidentificaciondestinatario = "";
            remesa.despacho.identificaciondestinatario = ds.Tables[0].Rows[0]["accountid"].ToString();
            remesa.despacho.razonsocialdestinatario = ds.Tables[0].Rows[0]["shiptoname"].ToString();
            remesa.despacho.direcciondestinatario = ds.Tables[0].Rows[0]["recipientaddress"].ToString();
            remesa.despacho.ciudaddestinatario = ds.Tables[0].Rows[0]["recipientcity"].ToString();
            remesa.despacho.telefonodestinatario = ds.Tables[0].Rows[0]["phonenumber"].ToString();

            remesa.despacho.unidad = new List<Unidad>();


            if (valorxcaja == "-1")
            {
                valor = int.Parse(ds.Tables[0].Rows[0]["declaredvalue"].ToString()) / int.Parse(ds.Tables[0].Rows[0]["numpacks"].ToString());
            }
            else
            {
                valor = int.Parse(valorxcaja);
            }

            foreach (DataRow package in ds.Tables[1].Rows)
            {
                //  valor = int.Parse(valorxcaja);// * int.Parse(package["package_num"].ToString());

                totalvalorproducto += valor;

                totalpeso += int.Parse(package["weight"].ToString());

                remesa.despacho.unidad.Add(new Unidad
                {
                    tipounidad = "TIPO_UND_PAQ",
                    cantidadunidades = package["package_num"].ToString(),
                    kilosreales = package["weight"].ToString(),
                    pesovolumen = package["volweight"].ToString(),
                    valormercancia = valor.ToString(),
                    alto = package["height"].ToString(),
                    ancho = package["width"].ToString(),
                    largo = package["length"].ToString(),
                });
            }

            remesa.despacho.documentoreferencia = new List<Documentoreferencium>();
            remesa.despacho.documentoreferencia.Add(new Documentoreferencium
            {
                tipodocumento = "FA",
                numerodocumento = ds.Tables[0].Rows[0]["docnumber"].ToString(),
                fechadocumento = ds.Tables[0].Rows[0]["docdate"].ToString()
            });

            remesa.despacho.direccionremitente = senderaddress;
            remesa.despacho.telefonoremitente = senderphone;
            remesa.despacho.generarDocumentos = generarDocumentos;
            remesa.despacho.totalpeso = totalpeso.ToString();
            remesa.despacho.totalvalormercancia = totalvalorproducto.ToString();

            var a = JsonConvert.SerializeObject(remesa);

            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(remesa);

            RestResponse response = await client.ExecuteAsync(request);


            TCCRemesaResponse responseJSON = JsonConvert.DeserializeObject<TCCRemesaResponse>(response.Content);

            if (responseJSON.respuesta != "0")
                throw new Exception(responseJSON.mensaje);


            V2OpeDocument V2OpeDocument = await Task.Run(() => curRequest.curContext.db.V2OpeDocuments.Where(f => f.Docnumber == ds.Tables[0].Rows[0]["docnumber"].ToString()).First());

            V2OpeDocument.DeliveryRowidService = curRequest.curDeliveryService.Rowid;
            V2OpeDocument.DeliveryResponse = response.Content;
            V2OpeDocument.DeliveryPackinglist = responseJSON.urlrelacionenvio;
            V2OpeDocument.DeliveryLabels = responseJSON.urlrotulos;
            V2OpeDocument.Trackingnumber = responseJSON.remesa;
            V2OpeDocument.Releaseon = DateTime.Now;
            V2OpeDocument.Releaseby = payload.username;

            curRequest.curContext.db.V2OpeDocuments.Update(V2OpeDocument);
            await Task.Run(() => curRequest.curContext.db.SaveChangesAsync());

            return responseJSON;
        }


        public async Task<dynamic> ConsultarRemesaAsync(DataSet ds)
        {
            //  URI						
            //  Producción	http://clientes.tcc.com.co/servicios/informacionremesas.asmx					
            //  Calidad	http://clientes.tcc.com.co/preservicios/informacionremesas.asmx		
            //  Operación	ConsultarInformacionRemesasEstadosUEN		


            //string endpoint = "http://clientes.tcc.com.co/preservicios/liquidacionacuerdos.asmx";
            string endpoint = config["endpoint"];

            //string clave = "CLIENTETCC608W3A61CJ"; // Clave asignada por TCC para el consumo de los servicios
            string clave = config["clave"]; // Clave asignada por TCC para el consumo de los servicios

            TCCConsultaServiceReference.InformacionRemesasSoapClient client = new TCCConsultaServiceReference.InformacionRemesasSoapClient(TCCConsultaServiceReference.InformacionRemesasSoapClient.EndpointConfiguration.InformacionRemesasSoap);
            TCCConsultaServiceReference.ConsultarInformacionRemesasEstadosUENRequest request = new TCCConsultaServiceReference.ConsultarInformacionRemesasEstadosUENRequest();

            request.Clave = clave; // Clave o usuario asignado por TCC para realizar el consumo del servicio
                                   //request.remesasrespuesta = "4490064100"; // Código de respuesta que indica la respuesta del web-service. Si es cero (0) se ejecutó normalmente, en caso contrario el número indica la ocurrencia de algún error o parámetro inconsistente.
            request.remesas = new TCCConsultaServiceReference.RemesaUEN[1];

            var remesa = new TCCConsultaServiceReference.RemesaUEN();
            //remesa.numeroremesa = "4490064100"; // Número de remesa previamente asignada por TCC al desapacho.
            remesa.numeroremesa = ds.Tables[0].Rows[0]["numeroremesa"].ToString(); // Número de remesa previamente asignada por TCC al desapacho.
            remesa.unidadnegocio = ""; // Fecha en que las remesas agrupadas serán despachadas (Enviar vacio)
            request.remesas[0] = remesa;

            request.Respuesta = 0; // Código de respuesta que indica la respuesta del web-service. Si es cero (0) se ejecutó normalmente, en caso contrario el número indica la ocurrencia de algún error o parámetro inconsistente.
            //request.Mensaje = "4490064100"; // Número de remesa previamente asignada por TCC al desapacho.
            request.Mensaje = ds.Tables[0].Rows[0]["numeroremesa"].ToString(); // Número de remesa previamente asignada por TCC al desapacho.

            var response = await client.ConsultarInformacionRemesasEstadosUENAsync(request);

            return "OK";
        }


        public async Task<dynamic> CotizarRemesaAsync(DataSet ds, ProcessRequest payload)
        {

            dynamic config = UtilTool.GetDynamicFromJSON(curRequest.curDeliveryService.SetupAttibutesValue);

            //NOTA: Esto solo funciona para el ambiente de produccion de TCC en pruebas tienen un fallo interno
            // URI Producción	http://clientes.tcc.com.co/servicios/liquidacionacuerdos.asmx					
            // Calidad (Cliente)						
            // Pruebas (Interno)	http://clientes.tcc.com.co/preservicios/liquidacionacuerdos.asmx					
            // Clave Pruebas	CLIENTETCC608W3A61CJ					
            // Operación	consultarLiquidacion


            // clave = "CALIWSIMPORMEDICAL"
            // clave = "calcobo" 

            string endpoint = curRequest.curDeliveryCompany.QuoteEndpoint;

            //string clave = "CALIWSIMPORMEDICAL"; // Clave asignada por TCC para el consumo de los servicios
            //string clave = config["clave"]; // Clave asignada por TCC para el consumo de los servicios
            string clave = curRequest.curDeliveryCompany.AccountPassword;

            TCCLiquidacionServiceReference.LiquidacionAcuerdosSoapClient client = new TCCLiquidacionServiceReference.LiquidacionAcuerdosSoapClient(TCCLiquidacionServiceReference.LiquidacionAcuerdosSoapClient.EndpointConfiguration.LiquidacionAcuerdosSoap);


            TCCLiquidacionServiceReference.Liquidacion Liquidacion = new TCCLiquidacionServiceReference.Liquidacion();

            //Liquidacion.cuenta = "1777901","1554300"; // Numero de cuenta asignada por TCC al cliente (Para cotizar con acuerdos) Enviar vacio para full tarifa
            // Liquidacion.idunidadestrategicanegocio = "1"; //Codigo de la Unidad Estrategica de Negocio (1: Paquete, 2: Mensajeria)
            //Liquidacion.tipoenvio = "1"; // Define el tipo de mercancia que será liquidado (1: Paquete, 2: Mensajeria)
            Liquidacion.tipoenvio = config["tipoenvio"]; // Define el tipo de mercancia que será liquidado (1: Paquete, 2: Mensajeria)

            //Liquidacion.cuenta = "1389900";
            //Liquidacion.cuenta = config["cuenta"];
            Liquidacion.cuenta = curRequest.curDeliveryCompany.AccountUsername;

            //Liquidacion.idciudadorigen = ds.Tables[0].Rows[0]["sendercity"].ToString();  // "05001000"; // Codigo de la ciudad origen del despacho (Tomado del maestro de ciudades TCC, tambien puede enviar códigos Dane de 8 digitos)
            Liquidacion.idciudadorigen = config["sendercity"];  // "05001000"; // Codigo de la ciudad origen del despacho (Tomado del maestro de ciudades TCC, tambien puede enviar códigos Dane de 8 digitos)
            Liquidacion.idciudaddestino = ds.Tables[0].Rows[0]["recipientcity"].ToString(); // Codigo de la ciudad destino del depacho (Tomado del maestro de ciudades TCC, tambien puede enviar código Dane de 8 Digitos)
            //Liquidacion.valormercancia = ds.Tables[0].Rows[0]["declaredvalue"].ToString(); // Valor declarado de la mercancia
            string valorxcaja = config["valorxcaja"];
            int valor = 0;

            if (valorxcaja == "-1")
            {
                valor = (int)float.Parse(ds.Tables[0].Rows[0]["declaredvalue"].ToString());
            }
            else
            {
                valor = int.Parse(valorxcaja) * int.Parse(ds.Tables[0].Rows[0]["numpacks"].ToString());
            }

            Liquidacion.valormercancia = valor.ToString();

            //Liquidacion.boomerang = "0"; // Cantidad de documentos boomerang a enviar (Enviar 0)
            Liquidacion.boomerang = config["boomerang"]; // Cantidad de documentos boomerang a enviar (Enviar 0)
                                                         // Liquidacion.fecharemesa = ""; // Fecha de la remesas para despachos enviados por TCC Mensajeria (Enviar Vacio).

            Liquidacion.unidades = new TCCLiquidacionServiceReference.ArrayOfUnidad();
            TCCLiquidacionServiceReference.unidad unidad = new TCCLiquidacionServiceReference.unidad();
            unidad.numerounidades = ds.Tables[0].Rows[0]["numpacks"].ToString(); // Numero de unidades
            unidad.pesovolumen = ds.Tables[0].Rows[0]["volweight"].ToString();

            //unidad.pesoreal = ds.Tables[0].Rows[0]["weight"].ToString(); // peso real 
            // unidad.pesovolumen = "20.00"; // Peso Volumen
            // unidad.alto = "5"; // Alto de la mercancia


            Liquidacion.unidades.Add(unidad);

            var response = await client.consultarliquidacionAsync(clave, Liquidacion);


            //throw new Exception(response.Body.consultarliquidacionResult.respuesta.mensaje);

            bool newRecord = false;

            V2OpeDeliveryQuote V2OpeDeliveryQuote = await Task.Run(() => curRequest.curContext.db.V2OpeDeliveryQuotes.Where(f => f.Docnumber == ds.Tables[0].Rows[0]["docnumber"].ToString()
                                                                                                               && f.CompanyCode == curRequest.curDeliveryCompany.CompanyCode
                                                                                                                && f.ServiceCode == curRequest.curDeliveryService.ServiceCode).FirstOrDefault());

            if (V2OpeDeliveryQuote == null)
            {
                newRecord = true;
                V2OpeDeliveryQuote = new V2OpeDeliveryQuote();
            }

            V2OpeDeliveryQuote.Docnumber = ds.Tables[0].Rows[0]["docnumber"].ToString();
            V2OpeDeliveryQuote.CompanyCode = curRequest.curDeliveryCompany.CompanyCode;
            V2OpeDeliveryQuote.ServiceCode = curRequest.curDeliveryService.ServiceCode;
            V2OpeDeliveryQuote.DeclaredValue = float.Parse(ds.Tables[0].Rows[0]["declaredvalue"].ToString());

            if (response.Body.consultarliquidacionResult.respuesta.codigo != "0")
            {
                V2OpeDeliveryQuote.FreightValue = 0;
                V2OpeDeliveryQuote.IndError = true;
                V2OpeDeliveryQuote.Response = response.Body.consultarliquidacionResult.respuesta.mensaje;
            }
            else
            {
                V2OpeDeliveryQuote.FreightValue = float.Parse(response.Body.consultarliquidacionResult.total.totaldespacho);
                V2OpeDeliveryQuote.IndError = false;
                V2OpeDeliveryQuote.Response = null;
            }

            V2OpeDeliveryQuote.Msg = response.Body.consultarliquidacionResult.respuesta.mensaje;
            V2OpeDeliveryQuote.Createdby = "admin";
            V2OpeDeliveryQuote.Createdon = DateTime.Now;


            if (newRecord)
            {
                curRequest.curContext.db.V2OpeDeliveryQuotes.Add(V2OpeDeliveryQuote);
            }
            else
            {
                curRequest.curContext.db.V2OpeDeliveryQuotes.Update(V2OpeDeliveryQuote);
            }

            await Task.Run(() => curRequest.curContext.db.SaveChangesAsync());

            return new WMSQuoteResponse { DeclaredtValue = 0, FreightValue = 0, Msg = "", Success = true };

        }

    }
}
