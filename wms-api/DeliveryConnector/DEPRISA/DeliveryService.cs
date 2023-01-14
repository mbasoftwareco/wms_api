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
using System.Text;
using System.IO;

namespace wms_api.DeliveryConnector.DEPRISA
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

            string endpoint = curRequest.curDeliveryCompany.QuoteEndpoint;

            string user = curRequest.curDeliveryCompany.AccountUsername;

            string password = curRequest.curDeliveryCompany.AccountPassword;

            string center = curRequest.curDeliveryCompany.AccountCode;

            MPrintTemplate template = curRequest.curContext.db.MPrintTemplates.FirstOrDefault(x => x.Code == "CotizarDeprisa");

            string xmlGuia = template.Body;

            string sendername = config["sendername"];
            
            string senderid = config["senderid"];

            string sendercity = config["sendercity"];

            string sendercityname = config["sendercityname"];

            string senderaddress = config["senderaddress"];

            string senderphone = config["senderphone"];

            string valorxcaja = config["valorxcaja"];

            string soapmethod = config["soapmethod"];

            int valor = int.Parse(valorxcaja) * int.Parse(ds.Tables[0].Rows[0]["numpacks"].ToString());

            List<string[]> data = new List<string[]>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                foreach (DataColumn column in ds.Tables[0].Columns)
                {
                    if (column.ColumnName.StartsWith("__"))
                        data.Add(new string[2] { column.ColumnName, row[column.ColumnName].ToString().Trim() });
                }
            }


            data.Add(new string[2] { "__TIPO_ENVIO", "N" });
            data.Add(new string[2] { "__CLIENTE_REMITENTE", senderid });
            data.Add(new string[2] { "__CENTRO_REMITENTE", center });
            data.Add(new string[2] { "__PAIS_REMITENTE", "057" });
            data.Add(new string[2] { "__POBLACION_REMITENTE", sendercityname });
            data.Add(new string[2] { "__IMPORTE_VALOR_DECLARADO", valor.ToString() });
            data.Add(new string[2] { "__TIPO_MONEDA", "COP" });



            xmlGuia = UtilTool.ReplaceTempleteList(xmlGuia, data);

            string response = UtilTool.CallSoap(xmlGuia, endpoint, soapmethod,false);

            StringReader reader = new StringReader(response);
            DataSet dsResult = new DataSet();
            dsResult.ReadXml(reader);

            if (dsResult.Tables.Count == 0 || dsResult.Tables["return"] == null || dsResult.Tables["return"].Rows.Count == 0)
                throw new Exception("Bad XML Response");


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


            //if (!response.IsSuccessful)
            //{
            //    V2OpeDeliveryQuote.FreightValue = 0;
            //   V2OpeDeliveryQuote.IndError = true;
            //   V2OpeDeliveryQuote.Response = response.Content;
            //
            //}
            //else
            //{
            V2OpeDeliveryQuote.FreightValue = 0;//responseJSON.flete_total;
            V2OpeDeliveryQuote.IndError = false;
            V2OpeDeliveryQuote.Response = null;
            //}

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
                FreightValue = 0,//responseJSON.flete_total,
                Msg = "",
                Success = true//response.IsSuccessful
            };

        }

        public Task<dynamic> CrearRemesaAsync(DataSet ds, ProcessRequest payload)
        {
            throw new NotImplementedException();
        }

        public Task<dynamic> ConsultarRemesaAsync(DataSet ds)
        {
            throw new NotImplementedException();
        }
    }
}
