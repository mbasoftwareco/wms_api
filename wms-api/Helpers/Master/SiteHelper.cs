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
    public class SiteHelper
    {

        private IConfiguration Configuration;
        private string CurrentUser;

        private WMS_LIGERO_LIVEContext _db = new WMS_LIGERO_LIVEContext();

        public SiteHelper() { }

        public SiteHelper(IConfiguration _configuration)
        {
            this.Configuration = _configuration;
            this._db = new WMS_LIGERO_LIVEContext();
        }


        public async Task<dynamic> Get(string id)
        {
            var record = _db.MSites.Where(f => f.Site == id).FirstOrDefault();

            if (record == null)
            {
                throw new Exception("Not Found.");
            }

            return record;
        }

        public async Task<dynamic> Post(MSite recordNew, MasterRequest payload)
        {


            bool exists = false;

            MSite record = _db.MSites.FirstOrDefault(c => c.Site == recordNew.Site);

            if (record != null)
                exists = true;
            else
            {
                if (_db.MBins.Any(f => f.Site == recordNew.Site))
                    throw new Exception($"Registro ya existe en la plataforma. Registration already exists on the platform.");

                record = new MSite
                {
                    Regdate = DateTime.Now
                };
            }

            record.City = recordNew.City;
            record.Address = recordNew.Address;
            record.Country = recordNew.Country;
            record.Regdate = recordNew.Regdate;
            record.SiteName = recordNew.SiteName;
            record.Site = recordNew.Site;


            if (exists)
            {
                _db.MSites.Update(record);
            }
            else
            {
                _db.MSites.Add(recordNew);
            }


            await _db.SaveChangesAsync();

            var response = new
            {
                Result = "OK",
                Message = "",
                Data = recordNew.Site
            };

            return response;
        }


    }
}
