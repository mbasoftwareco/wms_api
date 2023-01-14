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
    public class BinHelper
    {

        private IConfiguration Configuration;

        private WMS_LIGERO_LIVEContext _db = new WMS_LIGERO_LIVEContext();

        public BinHelper() { }

        public BinHelper(IConfiguration _configuration)
        {
            this.Configuration = _configuration;
            this._db = new WMS_LIGERO_LIVEContext();
        }


        public async Task<dynamic> Get(int id)
        {
            var record = _db.MBins.Where(f => f.Rowid == id).FirstOrDefault();

            if (record == null)
            {
                throw new Exception("Not Found.");
            }

            return record;
        }

        public async Task<dynamic> Post(MBin recordNew, MasterRequest payload)
        {
            bool exists = false;

            MBin record = _db.MBins.FirstOrDefault(c => c.Rowid == recordNew.Rowid);

            if (record != null)
            {
                exists = true;

                record.Site = recordNew.Site;
                record.Bincode = recordNew.Bincode;
            }
            else
            {
                if (_db.MBins.Any(f => f.Site == recordNew.Site && f.Bincode == recordNew.Bincode))
                    throw new Exception($"Registro ya existe en la plataforma. Registration already exists on the platform.");

                recordNew.Createdby = payload.username;
                recordNew.Createdon = DateTime.Now;
                recordNew.Company = "";
                recordNew.AisleNo = "";
                recordNew.SectionNo = "";
                recordNew.LevelNo = "";
            }


            if (exists)
            {
                _db.MBins.Update(record);
            }
            else
                _db.MBins.Add(recordNew);


            await _db.SaveChangesAsync();

            var response = new
            {
                Result = "OK",
                Message = "",
                Data = recordNew.Rowid
            };

            return response;
        }


    }
}
