using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using wms_api.Models;
using wms_api.Utils;
using wms_api.Wrappers;

namespace wms_api.Helpers
{
    public class DeliveryCompanyHelper
    {

        private IConfiguration Configuration;

        private WMS_LIGERO_LIVEContext _db = new WMS_LIGERO_LIVEContext();

        public DeliveryCompanyHelper() { }


        public DeliveryCompanyHelper(IConfiguration _configuration)
        {
            this.Configuration = _configuration;
            this._db = new WMS_LIGERO_LIVEContext();
        }


        public async Task<dynamic> Get(string id)
        {
            var record = _db.V2WmsDeliveryCompanies.Where(f => f.Rowid.ToString() == id).FirstOrDefault();

            if (record == null)
            {
                throw new Exception("Not Found.");
            }

            return record;
        }


        public async Task<dynamic> Post(V2WmsDeliveryCompany recordNew, MasterRequest payload)
        {


            bool exists = false;

            V2WmsDeliveryCompany record = _db.V2WmsDeliveryCompanies.FirstOrDefault(c => c.Rowid == recordNew.Rowid);

            if (record != null)
            {
                exists = true;

                record.CompanyCode = recordNew.CompanyCode;
                record.CompanyName = recordNew.CompanyName;
                record.CountryCode = recordNew.CountryCode;
                record.IndPackingConsolidated = recordNew.IndPackingConsolidated;
                record.IndPackinglist = recordNew.IndPackinglist;
                record.QuoteEndpoint = recordNew.QuoteEndpoint;
                record.GuideEndpoint = recordNew.GuideEndpoint;
                record.TrackingEndpoint = recordNew.TrackingEndpoint;

                record.AccountUsername = recordNew.AccountUsername;
                record.AccountPassword = recordNew.AccountPassword;
                record.AccountCode = recordNew.AccountCode;
                record.QuoteEndpoint2 = recordNew.QuoteEndpoint2;
                record.LabelsEndpoint = recordNew.LabelsEndpoint;
                record.IndPkglabels = recordNew.IndPkglabels;
                record.ServiceCode = recordNew.ServiceCode;
                record.ServiceName = recordNew.ServiceName;
                record.IndManual = recordNew.IndManual == null ? 0 : recordNew.IndManual;
                record.IndActivo = recordNew.IndActivo == null ? 1 : recordNew.IndActivo;
            }
            else
            {

                if (_db.V2WmsDeliveryCompanies.Any(f => f.CompanyCode == recordNew.CompanyCode))
                    throw new Exception($"Registro ya existe en la plataforma. Registration already exists on the platform.");


                recordNew.Createdon = DateTime.Now;
                recordNew.Createdby = payload.username;
            }

            if (exists)
            {
                _db.V2WmsDeliveryCompanies.Update(record);
            }
            else
            {
                _db.V2WmsDeliveryCompanies.Add(recordNew);
            }

            await _db.SaveChangesAsync();

            var response = new
            {
                Result = "OK",
                Message = "",
                Data = recordNew.CompanyCode
            };

            return response;
        }


    }
}
