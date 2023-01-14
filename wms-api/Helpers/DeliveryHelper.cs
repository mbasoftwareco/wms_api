using Microsoft.Extensions.Configuration;
using System.Data;
using System.Threading.Tasks;
using wms_api.Utils;
using wms_api.Wrappers;
using wms_api.Models;
using System.Linq;
using System.Collections.Generic;
using wms_api.Wrappers.Transportadoras;
using wms_api.DeliveryConnector;
using System;
using Newtonsoft.Json;

namespace wms_api.Helpers
{
    public class DeliveryHelper
    {

        // private WMS_LIGERO_LIVEContext db = new WMS_LIGERO_LIVEContext();

        private IConfiguration Configuration;
        private WMS_LIGERO_LIVEContext _db = new WMS_LIGERO_LIVEContext();

        public DeliveryHelper() { }

        public DeliveryHelper(IConfiguration _configuration)
        {
            this.Configuration = _configuration;
            this._db = new WMS_LIGERO_LIVEContext();
        }

        public async Task<dynamic> DeliveryAction(ProcessRequest payload)
        {
            switch (payload.action)
            {
                case "QUOTE":
                    return ProcessQuotes(payload);

                case "DELIVERY_CONFIRM":
                    return ConfirmDelivery(payload);

                case "DELIVERY_COMPLETED":
                    return "";

                case "UPDATE_TARIFA":
                    return updateTarifa(payload);

                case "UPDATE_TRACKINGNUMBER":
                    return updateTrackingNumber(payload);

                case "UPDATE_DELIVERYCONTACT":
                    return updateDeliveryContact(payload);

                case "UPDATE_COMPANY":
                    return updateComany(payload);

                case "CONFIRM_PICKUP":
                    return confirmPickUp(payload);

                default:
                    return DeliveryExeAction(payload);
            }

        }


        public async Task<dynamic> ProcessQuotes(ProcessRequest payload)
        {

            List<WMSQuoteResponse> quotes = new List<WMSQuoteResponse>();

            DataSet ds = (new _WEB(this.Configuration)).sp_Delivery(payload.action, new WH_Obj
            {
                USERNAME = payload.username,
                DOCUMENT = payload.document,
                SITE = payload.site
            });

            var deliveryCompanies = await Task.Run(() => this._db.V2WmsDeliveryCompanies.Where(x => x.IndActivo == 1));

            foreach (var deliveryCompany in deliveryCompanies)
            {
                var deliveryServices = await Task.Run(() => this._db.V2MasterDeliveryServices
                .Where(f => f.CompanyCode == deliveryCompany.CompanyCode && f.IndActive == 1).ToList());

                foreach (var deliveryService in deliveryServices)
                {

                    DeliveryFactory deliveryFactory = DeliveryFactory.GetDeliveryFactory(new WMSDeliveryRequest
                    {
                        curContext = new _WEB(this.Configuration),
                        curDeliveryCompany = deliveryCompany,
                        curDeliveryService = deliveryService
                    });

                    try
                    {
                        if (deliveryFactory != null)
                        {
                            WMSQuoteResponse curQuote = await deliveryFactory.DeliveryService().CotizarRemesaAsync(ds, payload);
                            quotes.Add(curQuote);
                        }
                    }
                    catch (Exception ex)
                    {
                        //Grabar los errores en un log para revision.
                        LLogError error = new LLogError
                        {
                            Createdby = payload.username,
                            Createdon = DateTime.Now,
                            LogClass = "DeliveryService",
                            Process = deliveryService.Rowid.ToString(),
                            LogMessage = ex.Message
                        };

                        try
                        {
                            _db.LLogErrors.Add(error);

                            _db.SaveChanges();
                        }
                        catch (Exception i)
                        {
                            Console.WriteLine(i.Message);
                        }


                        continue;
                    }
                }
            }

            //Agregar quote "propios" y "otros" para el documento
            try
            {
                List<V2MasterDeliveryService> servicesPropio = _db.V2MasterDeliveryServices.Where(x => (x.CompanyCode == "PROPIO" || x.CompanyCode == "OTROS") && x.IndActive == 1).ToList();

                foreach (V2MasterDeliveryService service in servicesPropio)
                {
                    WMSQuoteResponse quoteManual = await cotizarRemesaOtros(ds, payload, service);
                    quotes.Add(quoteManual);
                }

            }
            catch (Exception ex)
            {
                //Grabar los errores en un log para revision.
            }

            return quotes;
        }

        public async Task<dynamic> ConfirmDelivery(ProcessRequest payload)
        {
            string company_code = "";
            string service_code = "";

            try
            {
                var data_captured = payload.data_captured.Split("-");
                company_code = data_captured[0].Trim();
                service_code = data_captured[1].Trim();
            }
            catch { }

            var _deliveryCompany = await Task.Run(() => this._db.V2WmsDeliveryCompanies.SingleOrDefault(x => x.CompanyCode == company_code));
            var _deliveryService = await Task.Run(() => this._db.V2MasterDeliveryServices.SingleOrDefault(x => x.CompanyCode == company_code && (x.ServiceCode == service_code || company_code == "OTROS" )));

            DataSet ds = (new _WEB(this.Configuration)).sp_Delivery(payload.action, new WH_Obj
            {
                USERNAME = payload.username,
                DOCUMENT = payload.document,
                SITE = payload.site
            });

            DeliveryFactory deliveryFactory = DeliveryFactory.GetDeliveryFactory(new WMSDeliveryRequest
            {
                curContext = new _WEB(this.Configuration),
                curDeliveryCompany = _deliveryCompany,
                curDeliveryService = _deliveryService
            });

            dynamic responseConfirm = null;

            if (deliveryFactory != null && (_deliveryCompany.IndManual == 0 || _deliveryCompany.IndManual == null))
                responseConfirm = await deliveryFactory.DeliveryService().CrearRemesaAsync(ds, payload);
            else if (_deliveryCompany.IndManual == 1)
                responseConfirm = await crearRemesaManual(ds, payload);


            return responseConfirm;

        }

        public dynamic DeliveryExeAction(ProcessRequest payload)
        {
            WH_Obj curWMSObject = new WH_Obj
            {
                USERNAME = payload.username,
                DOCUMENT = payload.document,
                SITE = payload.site,
                DATA_CAPTURED = payload.data_captured
            };

            return (new _WEB(this.Configuration)).sp_Delivery(payload.action, curWMSObject);
        }

        public async Task<WMSQuoteResponse> cotizarRemesaOtros(DataSet ds, ProcessRequest payload, V2MasterDeliveryService service)
        {
            try
            {
                bool newRecord = false;

                V2OpeDeliveryQuote V2OpeDeliveryQuote = await Task.Run(() => _db.V2OpeDeliveryQuotes.Where(f => f.Docnumber == ds.Tables[0].Rows[0]["docnumber"].ToString()
                                                                                                                    && f.CompanyCode == service.CompanyCode
                                                                                                                    && f.ServiceCode == service.ServiceCode).FirstOrDefault());
                if (V2OpeDeliveryQuote == null)
                {
                    newRecord = true;
                    V2OpeDeliveryQuote = new V2OpeDeliveryQuote();
                }

                V2OpeDeliveryQuote.Docnumber = ds.Tables[0].Rows[0]["docnumber"].ToString();
                V2OpeDeliveryQuote.CompanyCode = service.CompanyCode;
                V2OpeDeliveryQuote.ServiceCode = service.ServiceCode;
                V2OpeDeliveryQuote.DeclaredValue = 0;
                V2OpeDeliveryQuote.FreightValue = 0;
                V2OpeDeliveryQuote.IndError = false;
                V2OpeDeliveryQuote.Msg = "OK";
                V2OpeDeliveryQuote.Createdby = payload.username;
                V2OpeDeliveryQuote.Createdon = DateTime.Now;

                if (newRecord)
                {
                    _db.V2OpeDeliveryQuotes.Add(V2OpeDeliveryQuote);
                }
                else
                {
                    _db.V2OpeDeliveryQuotes.Update(V2OpeDeliveryQuote);
                }

                await Task.Run(() => _db.SaveChangesAsync());

                WMSQuoteResponse quoteOtros = new WMSQuoteResponse { DeclaredtValue = 0, FreightValue = 0, Msg = "OK", Success = true };

                return quoteOtros;
            }
            catch
            {
                return null;
            }
        }

        public async Task<dynamic> updateTarifa(ProcessRequest payload)
        {
            dynamic data = JsonConvert.DeserializeObject(payload.data_captured);

            int rowid = data["rowid"];

            double tarifa = data["tarifa"];

            V2OpeDeliveryQuote quoteManual = await Task.Run(() => _db.V2OpeDeliveryQuotes.FirstOrDefault(x => x.Rowid == rowid));

            quoteManual.FreightValue = tarifa;

            _db.V2OpeDeliveryQuotes.Update(quoteManual);

            await Task.Run(() => _db.SaveChangesAsync());

            var response = new
            {
                Result = "OK",
                Message = "",
                Data = ""
            };

            return response;
        }

        public async Task<dynamic> updateTrackingNumber(ProcessRequest payload)
        {
            dynamic data = JsonConvert.DeserializeObject(payload.data_captured);

            string docnumber = data["docnumber"];

            string trackingNumber = data["trackingNumber"];

            V2OpeDocument document = await Task.Run(() => _db.V2OpeDocuments.FirstOrDefault(x => x.Docnumber == docnumber));

            document.Trackingnumber = trackingNumber;

            _db.V2OpeDocuments.Update(document);

            await Task.Run(() => _db.SaveChangesAsync());

            var response = new
            {
                Result = "OK",
                Message = "",
                Data = ""
            };

            return response;
        }

        public async Task<dynamic> updateComany(ProcessRequest payload)
        {
            dynamic data = JsonConvert.DeserializeObject(payload.data_captured);

            int rowid = data["rowid"];

            string service = data["service_code"];

            V2OpeDeliveryQuote quoteManual = await Task.Run(() => _db.V2OpeDeliveryQuotes.FirstOrDefault(x => x.Rowid == rowid));

            quoteManual.ServiceCode = service;

            _db.V2OpeDeliveryQuotes.Update(quoteManual);

            await Task.Run(() => _db.SaveChangesAsync());

            var response = new
            {
                Result = "OK",
                Message = "",
                Data = ""
            };

            return response;
        }


        public async Task<dynamic> crearRemesaManual(DataSet ds, ProcessRequest payload)
        {
            string company_code = "";
            string service_code = "";

            try
            {
                var data_captured = payload.data_captured.Split("-");
                company_code = data_captured[0].Trim();
                service_code = data_captured[1].Trim();
            }
            catch { }

            V2MasterDeliveryService service = _db.V2MasterDeliveryServices.Where(x => x.CompanyCode == company_code /*&& x.ServiceCode == service_code*/ && x.IndActive == 1).FirstOrDefault();

            V2OpeDocument V2OpeDocument = await Task.Run(() => _db.V2OpeDocuments.Where(f => f.Docnumber == ds.Tables[0].Rows[0]["docnumber"].ToString()).First());

            V2OpeDocument.DeliveryRowidService = service.Rowid;
            V2OpeDocument.DeliveryResponse = service_code;
            V2OpeDocument.Trackingnumber = "MANUAL";

            V2OpeDocument.Releaseon = DateTime.Now;
            V2OpeDocument.Releaseby = payload.username;

            _db.V2OpeDocuments.Update(V2OpeDocument);
            await Task.Run(() => _db.SaveChangesAsync());

            var response = new
            {
                Result = "OK",
                Message = "",
                Data = ""
            };

            return response;
        }

        public async Task<dynamic> updateDeliveryContact(ProcessRequest payload)
        {
            dynamic data = JsonConvert.DeserializeObject(payload.data_captured);

            string docnumber = payload.document;
            string name = data["name"];
            string address = data["address"];
            string city = data["city"];
            string citydane = "";
            string state = "";
            string phone = data["phone"];
            string contact = data["contact"];
            string email = data["email"];

            try
            {
                string[] citystate = city.Split(',');

                city = citystate[0];

                state = citystate[1];

                citydane = await Task.Run(() => _db.V2MasterDeliveryCities.FirstOrDefault(x => x.Name == city).CodeDane);
            }
            catch
            {

            }

            V2ApiDocumentWork document = await Task.Run(() => _db.V2ApiDocumentWorks.FirstOrDefault(x => x.DocType == "SALESORDER" && x.DocNumber == docnumber));

            dynamic docdata = JsonConvert.DeserializeObject(document.JsonData1);

            document.JsonData2 = JsonConvert.SerializeObject(docdata);

            docdata["Account"]["Name"] = name;
            docdata["Cotizaci_n__r"]["ShippingStreet"] = address;
            docdata["Cotizaci_n__r"]["ShippingCity"] = city;
            docdata["Cotizaci_n__r"]["ShippingState"] = state;
            docdata["C_digo_DANE__c"] = citydane;

            docdata["Contact"]["FirstName"] = contact;
            docdata["Contact"]["LastName"] = "";
            docdata["Contact"]["Email"] = email;

            document.JsonData1 = JsonConvert.SerializeObject(docdata);

            _db.V2ApiDocumentWorks.Update(document);

            await Task.Run(() => _db.SaveChangesAsync());

            var response = new
            {
                Result = "OK",
                Message = "",
                Data = ""
            };

            return response;
        }

        public async Task<dynamic> confirmPickUp(ProcessRequest payload)
        {
            dynamic data = JsonConvert.DeserializeObject(payload.data_captured);

            string docnumber = payload.document;

            V2OpeDocument document = await Task.Run(() => _db.V2OpeDocuments.FirstOrDefault(x => x.Docnumber == docnumber));

            document.Deliveredon = DateTime.Now;
            document.Deliveredby = payload.username;

            _db.V2OpeDocuments.Update(document);

            await Task.Run(() => _db.SaveChangesAsync());

            var response = new
            {
                Result = "OK",
                Message = "",
                Data = ""
            };

            return response;
        }
    }
}
