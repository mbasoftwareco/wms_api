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
using Newtonsoft.Json.Linq;

namespace wms_api.DeliveryConnector.TRANSPRENSA
{
    public class DeliveryService : IDeliveryService
    {

        private static WMSDeliveryRequest curRequest { get; set; }

        public DeliveryService(WMSDeliveryRequest _curRequest)
        {
            curRequest = _curRequest;
        }


        public async Task<dynamic> CrearRemesaAsync(DataSet ds, ProcessRequest payload)
        {
            string endpoint = curRequest.curDeliveryCompany.GuideEndpoint;

            dynamic config = UtilTool.GetDynamicFromJSON(curRequest.curDeliveryService.SetupAttibutesValue);

            var client = new RestClient();

            var request = new RestRequest(endpoint, Method.Post);

            request.AddHeader("UsuarioCliente", curRequest.curDeliveryCompany.AccountUsername);
            request.AddHeader("PswdCliente", curRequest.curDeliveryCompany.AccountPassword);
            request.AddHeader("CodigoCliente", curRequest.curDeliveryCompany.AccountCode);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
            request.AddHeader("Connection", "keep-alive");

            List<object> packages = new List<object>();

            string valorxcaja = config["valorxcaja"];

            int valor = 0;

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
                //valor = int.Parse(valorxcaja);// * int.Parse(package["package_num"].ToString());

                packages.Add(new
                {
                    DetallePeso = package["weight"].ToString(),
                    DetalleVolumen = package["volweight"].ToString(),
                    DetalleValorDeclarado = valor.ToString(),
                    DetalleProductoCodigo = package["code_transprensa"].ToString(),
                    DetalleCantidad = package["unidades"].ToString(),
                    DetalleDescripcion = ""
                });
            }

            string sendercity = config["sendercity_dane"];

            string tiposervicio = config["tiposervicio"];

            string senderdocumenttype = config["senderdocumenttype"];

            string senderid = config["senderid"];

            string sendername = config["sendername"];

            string senderaddress = config["senderaddress"];

            string senderphone = config["senderphone"];

            string formapago = config["formapago"];

            var body = new
            {
                CiudadCodigoOrigen = sendercity,
                CiudadCodigoDestino = ds.Tables[0].Rows[0]["recipientcity"].ToString(),
                TipoServicio = tiposervicio,
                FormaPago = formapago,
                remitente = new
                {
                    RemitenteCodigo = "",
                    TipoDocumentoRemitenteCodigo = senderdocumenttype, //Tipo de documento. Valores validos: 1, (CEDULA), 2 (NIT), 3 (PASAPORTE), 4 (RIF), 5 (RUT), 6 (NIT - RIF), 7 (RUC), 8 (TARJETA DE IDENTIDAD)
                    RemitenteDocumento = senderid,
                    RemitenteNombre = sendername,
                    RemitenteDireccion = senderaddress,
                    RemitenteTelefono = senderphone,
                    RemitenteCiudadCodigo = sendercity,
                },

                destinatario = new
                {
                    DestinatarioCodigo = "",
                    TipoDocumentoDestinatarioCodigo = ds.Tables[0].Rows[0]["accountdocumenttype"].ToString(), //Tipo de documento. Valores validos: 1, (CEDULA), 2 (NIT), 3 (PASAPORTE), 4 (RIF), 5 (RUT), 6 (NIT - RIF), 7 (RUC), 8 (TARJETA DE IDENTIDAD)
                    DestinatarioDocumento = Utils.UtilTool.GetNumbers(ds.Tables[0].Rows[0]["accountid"].ToString()),
                    DestinatarioNombre = ds.Tables[0].Rows[0]["shiptoname"].ToString(),
                    DestinatarioDireccion = ds.Tables[0].Rows[0]["recipientaddress"].ToString(),
                    DestinatarioTelefono = ds.Tables[0].Rows[0]["phonenumber"].ToString(),
                    DestinatarioCiudadCodigo = ds.Tables[0].Rows[0]["recipientcity"].ToString(),
                },

                detalle = packages,

                //detalle = new[] {
                //       new {
                //            DetallePeso = "5",
                //            DetalleVolumen = "0",
                //            DetalleValorDeclarado = "100000",
                //            DetalleProductoCodigo = "3559",
                //            DetalleCantidad = "10",
                //            DetalleDescripcion = ""
                //        }
                //    },

                CentroCosto = "",
                OrdenCarga = "",
                OrdenCompra = "",
                DocumentoCliente = "",
                RemesaObservacion = "",
                RemesaCodigo = "",
                OtrosValores = ""
            };

            //var a = JsonConvert.SerializeObject(body);

            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(body);

            RestResponse response = await client.ExecuteAsync(request);

            TransprensaConfirm responseJSON = JsonConvert.DeserializeObject<TransprensaConfirm>(response.Content);

            if (responseJSON.Data == null || responseJSON.Success == false)
                throw new Exception(responseJSON.Msg);


            TransprensaRotulos rotulos = await ConsultaRotuloAsync(responseJSON.Data.First().Remesa);
            var remesa = await ConsultarRemesaAsync(responseJSON.Data.First().Remesa);

            V2OpeDocument V2OpeDocument = await Task.Run(() => curRequest.curContext.db.V2OpeDocuments.Where(f => f.Docnumber == ds.Tables[0].Rows[0]["docnumber"].ToString()).First());

            V2OpeDocument.DeliveryRowidService = curRequest.curDeliveryService.Rowid;
            V2OpeDocument.DeliveryResponse = response.Content;
            V2OpeDocument.Trackingnumber = responseJSON.Data.First().Remesa;

            if (rotulos.Data != null && rotulos.Data.Count > 0)
            {
                V2OpeDocument.DeliveryPackinglist = rotulos.Data.First().rotulo;
                V2OpeDocument.DeliveryLabels = rotulos.Data.First().rotulo;
            }
            //else
            //{
            //    V2OpeDocument.DeliveryLabels Rotulo no generado por transportadora
            //}

            V2OpeDocument.Releaseon = DateTime.Now;
            V2OpeDocument.Releaseby = payload.username;

            curRequest.curContext.db.V2OpeDocuments.Update(V2OpeDocument);
            await Task.Run(() => curRequest.curContext.db.SaveChangesAsync());

            return responseJSON;
        }


        public async Task<dynamic> ConsultaRotuloAsync(string remesa)
        {

            string endpoint = curRequest.curDeliveryCompany.LabelsEndpoint;
            var client = new RestClient(endpoint);
            var request = new RestRequest(endpoint, Method.Post);
            request.AddHeader("UsuarioCliente", curRequest.curDeliveryCompany.AccountUsername);
            request.AddHeader("PswdCliente", curRequest.curDeliveryCompany.AccountPassword);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            List<object> remesas = new List<object>();
            remesas.Add(new { remesa = remesa });

            var body = new
            {
                remesas = remesas
            };

            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(body);

            RestResponse response = await client.ExecuteAsync(request);

            TransprensaRotulos responseJSON = JsonConvert.DeserializeObject<TransprensaRotulos>(response.Content);

            if (!responseJSON.Success)
                throw new Exception(responseJSON.Msg);


            return responseJSON;
        }


        public async Task<dynamic> ConsultarRemesaAsync(string remesa)
        {

            //string endpoint = "http://181.48.223.66:8520/api/Remesas?NumeroRemesa=010404496888&ClienteNit=&ClienteCodigo=&RemesaFechaCreacion=&RemesaFechaModificacion&PaginaNumero=1";
            string endpoint = curRequest.curDeliveryCompany.TrackingEndpoint.Replace("{remesa}", remesa);
            var client = new RestClient(endpoint);
            var request = new RestRequest(endpoint, Method.Get);

            request.AddHeader("UsuarioCliente", curRequest.curDeliveryCompany.AccountUsername);
            request.AddHeader("PswdCliente", curRequest.curDeliveryCompany.AccountPassword);
            //request.AddHeader("CodigoCliente", curRequest.curDeliveryCompany.AccountCode);
            //request.AddHeader("CodigoCliente", "558"); 


            RestResponse response = await client.ExecuteAsync(request);

            TransprensaRotulos responseJSON = JsonConvert.DeserializeObject<TransprensaRotulos>(response.Content);

            if (responseJSON.Data == null || responseJSON.Success == false)
                throw new Exception(responseJSON.Msg);

            return response.Content;
        }


        public async Task<dynamic> CotizarRemesaAsync(DataSet ds, ProcessRequest payload)
        {

            string city = ds.Tables[0].Rows[0]["recipientcity_transprensa"].ToString().Trim();

            if (string.IsNullOrEmpty(city))
                throw new Exception("Ciudad No Valida");

            dynamic config = UtilTool.GetDynamicFromJSON(curRequest.curDeliveryService.SetupAttibutesValue);

            string endpoint = curRequest.curDeliveryCompany.QuoteEndpoint;

            var client = new RestClient(endpoint);

            var request = new RestRequest(endpoint, Method.Post);

            request.AddHeader("UsuarioCliente", curRequest.curDeliveryCompany.AccountUsername);
            request.AddHeader("PswdCliente", curRequest.curDeliveryCompany.AccountPassword);
            request.AddHeader("CodigoCliente", curRequest.curDeliveryCompany.AccountCode);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

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

            string sendercity = config["sendercity"];

            string tiposervicio = config["tiposervicio"];

            var body = new
            {
                CiudadOrigen = sendercity,
                CiudadDestino = ds.Tables[0].Rows[0]["recipientcity_transprensa"].ToString().Trim(),
                Peso = ds.Tables[0].Rows[0]["weight"].ToString(),
                Alto = ds.Tables[0].Rows[0]["height"].ToString(),
                Largo = ds.Tables[0].Rows[0]["length"].ToString(),
                Ancho = ds.Tables[0].Rows[0]["width"].ToString(),
                ValorDeclarado = valor.ToString(),
                Cantidad = ds.Tables[0].Rows[0]["numpacks"].ToString(),
                TipoServicio = tiposervicio
            };

            
            JObject o = JObject.FromObject(body);

            string body_ = JsonConvert.SerializeObject(o);
            
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(body);


            RestResponse response = await client.ExecuteAsync(request);

            TransprensaQuote responseJSON = JsonConvert.DeserializeObject<TransprensaQuote>(response.Content);

            //if (responseJSON.Data == null || responseJSON.Success == false)
            //    throw new Exception(responseJSON.Msg);


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
            V2OpeDeliveryQuote.DeclaredValue = responseJSON.Data.ValorDeclarado;

            if (responseJSON.Data == null || responseJSON.Success == false)
            {
                V2OpeDeliveryQuote.FreightValue = 0;
                V2OpeDeliveryQuote.IndError = true;
                V2OpeDeliveryQuote.Response = responseJSON.Msg;
            }
            else
            {
                V2OpeDeliveryQuote.FreightValue = responseJSON.Data.ValorFlete;
                V2OpeDeliveryQuote.IndError = false;
                V2OpeDeliveryQuote.Response = null;
            }

            V2OpeDeliveryQuote.Msg = responseJSON.Msg;
            V2OpeDeliveryQuote.Createdby = payload.username;
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

            return new WMSQuoteResponse { DeclaredtValue = responseJSON.Data.ValorDeclarado, FreightValue = responseJSON.Data.ValorFlete, Msg = responseJSON.Msg, Success = responseJSON.Success };
        }

        public Task<dynamic> ConsultarRemesaAsync(DataSet ds)
        {
            throw new NotImplementedException();
        }
    }
}
