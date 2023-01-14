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
using System.Text;
using System.IO;
using System.Xml;
using System.Globalization;

namespace wms_api.DeliveryConnector.COORDINADORA
{
    public class DeliveryService : IDeliveryService
    {
        private static WMSDeliveryRequest curRequest { get; set; }

        public DeliveryService(WMSDeliveryRequest _curRequest)
        {
            curRequest = _curRequest;
        }

        public async Task<dynamic> CotizarRemesaAsync(DataSet ds, ProcessRequest payload)
        {

            dynamic config = UtilTool.GetDynamicFromJSON(curRequest.curDeliveryService.SetupAttibutesValue);

            //string endpoint = "https://multisync.nubenegocios.com/api/"; //URL CONSUMO
            //string endpoint = config["endpoint"]; 
            string endpoint = curRequest.curDeliveryCompany.QuoteEndpoint;

            string endpoint2 = curRequest.curDeliveryCompany.QuoteEndpoint2;

            RestClient apiClient = new RestClient(baseUrl: endpoint);

            string apikeyID = config["APIKeyID"];
            apiClient.AddDefaultHeader("APIKeyID", apikeyID);//CONFIRM
            apiClient.AddDefaultHeader("Content-Type", "application/json");

            RestRequest request = new RestRequest("Coordinadora", Method.Post);
            request.RequestFormat = DataFormat.Json;

            dynamic dataToSend = new JObject();

            dataToSend.proceso = "Cotizar";
            dataToSend.data = new JObject();

            //apikey = "556c990e-90c7-11ec-b909-0242ac120002",
            //dataToSend.data.apikey = config["apikey"];
            dataToSend.data.apikey = curRequest.curDeliveryCompany.AccountCode;

            //clave = "zQ9qV8vK8dO3hJ2w"
            //dataToSend.data.clave = config["clave"];
            dataToSend.data.clave = curRequest.curDeliveryCompany.AccountPassword;

            //nit = "900261089", //NIT CLIENTE
            //dataToSend.data.nit = config["nit"]; //NIT CLIENTE
            dataToSend.data.nit = curRequest.curDeliveryCompany.AccountUsername; //NIT CLIENTE


            dataToSend.data.div = "01";
            dataToSend.data.cuenta = "1";
            dataToSend.data.producto = "0";
            //dataToSend.data.origen = ds.Tables[0].Rows[0]["sendercity"].ToString();
            dataToSend.data.origen = config["sendercity"];
            dataToSend.data.destino = ds.Tables[0].Rows[0]["recipientcity"].ToString();
            //dataToSend.data.valoracion = ds.Tables[0].Rows[0]["declaredvalue"].ToString();

            string valorxcaja = config["valorxcaja"];

            int valor = int.Parse(valorxcaja) * int.Parse(ds.Tables[0].Rows[0]["numpacks"].ToString());

            dataToSend.data.valoracion = valor.ToString();
            dataToSend.data.nivel_servicio = "";
            dataToSend.data.detalle = new JArray();

            /*
            dynamic curDetalle = new JObject();
            curDetalle.ubl = "0";
            curDetalle.alto = ds.Tables[0].Rows[0]["height"].ToString();
            curDetalle.ancho = ds.Tables[0].Rows[0]["width"].ToString();
            curDetalle.largo = ds.Tables[0].Rows[0]["length"].ToString();
            curDetalle.peso = ds.Tables[0].Rows[0]["weight"].ToString();
            curDetalle.unidades = ds.Tables[0].Rows[0]["numpacks"].ToString();
            dataToSend.data.detalle.Add(curDetalle);
            */

            dataToSend.data.detalle = JArray.Parse(ds.Tables[0].Rows[0]["detalle"].ToString());

            dataToSend.data.endpoint = endpoint2;

            string dataToSendStr = JsonConvert.SerializeObject(dataToSend);
            request.AddStringBody(dataToSendStr, "application/json");

            RestResponse response = await apiClient.ExecuteAsync(request);
            CoordinadoraQuote responseJSON = JsonConvert.DeserializeObject<CoordinadoraQuote>(response.Content);

            //if (!response.IsSuccessful)
            //    throw new Exception(response.ErrorException?.Message);

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
            V2OpeDeliveryQuote.DeclaredValue = double.Parse(ds.Tables[0].Rows[0]["declaredvalue"].ToString());


            if (!response.IsSuccessful)
            {
                V2OpeDeliveryQuote.FreightValue = 0;
                V2OpeDeliveryQuote.IndError = true;
                V2OpeDeliveryQuote.Response = response.Content;

            }
            else
            {
                V2OpeDeliveryQuote.FreightValue = responseJSON.flete_total;
                V2OpeDeliveryQuote.IndError = false;
                V2OpeDeliveryQuote.Response = null;
            }

            V2OpeDeliveryQuote.Msg = "";
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

            return new WMSQuoteResponse
            {
                DeclaredtValue = V2OpeDeliveryQuote.DeclaredValue,
                FreightValue = responseJSON.flete_total,
                Msg = "",
                Success = response.IsSuccessful
            };
        }

        public async Task<dynamic> CrearRemesaAsync(DataSet ds, ProcessRequest payload)
        {
            dynamic config = UtilTool.GetDynamicFromJSON(curRequest.curDeliveryService.SetupAttibutesValue);

            string endpoint = curRequest.curDeliveryCompany.GuideEndpoint;

            MPrintTemplate template = curRequest.curContext.db.MPrintTemplates.FirstOrDefault(x => x.Code == "Agw_typeAtributosRetorno");

            string xmlGuia = template.Body;

            string xmlDetalle = template.Pltemplate;

            string usuariocoordinadora = config["usuariocoordinadora"];

            string clavecoordinadora = config["clavecoordinadora"];

            string idclientecoordinadora = config["idclientecoordinadora"];

            string sendername = config["sendername"];

            string sendercity = config["sendercity"];

            string senderaddress = config["senderaddress"];

            string senderphone = config["senderphone"];

            string valorxcaja = config["valorxcaja"];

            string soapmethod = config["soapmethod"];

            int valor = int.Parse(valorxcaja) * int.Parse(ds.Tables[0].Rows[0]["numpacks"].ToString());

            string address = ds.Tables[0].Rows[0]["recipientaddress"].ToString();

            address = UtilTool.ReplaceTildes(address);

            List<string[]> data = new List<string[]>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                foreach (DataColumn column in ds.Tables[0].Columns)
                {
                    if (column.ColumnName.StartsWith("__"))
                        data.Add(new string[2] { column.ColumnName, row[column.ColumnName].ToString().Trim() });
                }
            }

            data.Add(new string[2] { "__codigo_remision", "" });
            data.Add(new string[2] { "__fecha", "" });
            data.Add(new string[2] { "__id_cliente", idclientecoordinadora });
            data.Add(new string[2] { "__id_remitente", "" });
            data.Add(new string[2] { "__nombre_remitente", sendername });
            data.Add(new string[2] { "__direccion_remitente", senderaddress });
            data.Add(new string[2] { "__telefono_remitente", senderphone });
            data.Add(new string[2] { "__ciudad_remitente", sendercity });
            data.Add(new string[2] { "__div_destinatario", "1" });
            data.Add(new string[2] { "__direccion_destinatario", address });
            data.Add(new string[2] { "__valor_declarado", valor.ToString() });
            data.Add(new string[2] { "__codigo_cuenta", "1" });
            data.Add(new string[2] { "__codigo_producto", "0" });
            data.Add(new string[2] { "__nivel_servicio", "1" });
            data.Add(new string[2] { "__linea", "1" });
            data.Add(new string[2] { "__contenido", "Documento: " + ds.Tables[0].Rows[0]["docnumber"].ToString() + ", " + ds.Tables[0].Rows[0]["numpacks"].ToString() + " cajas" });
            data.Add(new string[2] { "__referencia", ds.Tables[0].Rows[0]["docnumber"].ToString() });
            data.Add(new string[2] { "__observaciones", "" });
            data.Add(new string[2] { "__estado", "IMPRESO" });
            data.Add(new string[2] { "__cuenta_contable", "" });
            data.Add(new string[2] { "__centro_costos", "" });
            #region Recaudos
            /*data.Add(new string[2] { "__referencia", ds.Tables[0].Rows[0]["docnumber"].ToString() });
            data.Add(new string[2] { "__valor", valor.ToString() });
            data.Add(new string[2] { "__forma_pago", "0" });*/
            data.Add(new string[2] { "__referencia", "" });
            data.Add(new string[2] { "__valor", "" });
            data.Add(new string[2] { "__forma_pago", "" });
            #endregion
            data.Add(new string[2] { "__usuario_vmi", "" });
            data.Add(new string[2] { "__formato_impresion", "" });
            #region Notificaciones
            data.Add(new string[2] { "__tipo_medio", "1" });
            //data.Add(new string[2] { "__destino_notificacion", "" });
            #endregion
            #region Atributos Retorno
            data.Add(new string[2] { "__nit", "" });
            data.Add(new string[2] { "__div", "" });
            data.Add(new string[2] { "__nombre", "" });
            data.Add(new string[2] { "__direccion", "" });
            data.Add(new string[2] { "__codigo_ciudad", "" });
            data.Add(new string[2] { "__telefono", "" });
            #endregion
            data.Add(new string[2] { "__nro_doc_radicados", "" });
            data.Add(new string[2] { "__nro_sobre", "" });
            data.Add(new string[2] { "__codigo_vendedor", "" });
            data.Add(new string[2] { "__usuario", usuariocoordinadora });
            data.Add(new string[2] { "__clave", clavecoordinadora });
            #region Detalle
            List<string[]> dataDetalle = new List<string[]>();

            string detalles = "";

            foreach (DataRow row in ds.Tables[1].Rows)
            {
                dataDetalle = new List<string[]>();

                foreach (DataColumn column in ds.Tables[1].Columns)
                {
                    if (column.ColumnName.StartsWith("__"))
                        dataDetalle.Add(new string[2] { column.ColumnName, row[column.ColumnName].ToString().Trim() });
                }

                detalles += UtilTool.ReplaceTempleteList(xmlDetalle, dataDetalle);
            }

            data.Add(new string[2] { "__detalle", detalles });
            #endregion

            xmlGuia = UtilTool.ReplaceTempleteList(xmlGuia, data);

            string response = UtilTool.CallSoap(xmlGuia, endpoint, soapmethod);

            StringReader reader = new StringReader(response);
            DataSet dsResult = new DataSet();
            dsResult.ReadXml(reader);

            if (dsResult.Tables.Count == 0 || dsResult.Tables["return"] == null || dsResult.Tables["return"].Rows.Count == 0)
                throw new Exception("Bad XML Response");

            V2OpeDocument V2OpeDocument = await Task.Run(() => curRequest.curContext.db.V2OpeDocuments.Where(f => f.Docnumber == ds.Tables[0].Rows[0]["docnumber"].ToString()).First());

            V2OpeDocument.DeliveryRowidService = curRequest.curDeliveryService.Rowid;
            V2OpeDocument.DeliveryResponse = response;
            V2OpeDocument.DeliveryPackinglist = dsResult.Tables["return"].Rows[0]["url_terceros"].ToString();
            V2OpeDocument.DeliveryLabels = dsResult.Tables["return"].Rows[0]["pdf_guia"].ToString();
            V2OpeDocument.Trackingnumber = dsResult.Tables["return"].Rows[0]["codigo_remision"].ToString();
            V2OpeDocument.Releaseon = DateTime.Now;
            V2OpeDocument.Releaseby = payload.username;

            curRequest.curContext.db.V2OpeDocuments.Update(V2OpeDocument);
            await Task.Run(() => curRequest.curContext.db.SaveChangesAsync());

            return response;
        }

        public Task<dynamic> ConsultarRemesaAsync(DataSet ds)
        {
            throw new NotImplementedException();
        }

    }
}
