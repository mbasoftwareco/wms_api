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
    public class PackageHelper
    {

        private IConfiguration Configuration;

        private WMS_LIGERO_LIVEContext _db = new WMS_LIGERO_LIVEContext();

        public PackageHelper() { }


        public PackageHelper(IConfiguration _configuration)
        {
            this.Configuration = _configuration;
            this._db = new WMS_LIGERO_LIVEContext();
        }



        public async Task<dynamic> Get(string id)
        {
            var record = _db.V2MasterPackages.Where(f => f.Rowid.ToString() == id).FirstOrDefault();

            if (record == null)
            {
                throw new Exception("Not Found.");
            }

            return record;
        }


        public async Task<dynamic> Post(V2MasterPackage recordNew, MasterRequest payload)
        {
            
            bool exists = false;

            V2MasterPackage record = _db.V2MasterPackages.FirstOrDefault(c => c.Rowid == recordNew.Rowid);

            if (record != null)
            {
                exists = true;

                record.PackageName = recordNew.PackageName;
                record.MaxWeight = recordNew.MaxWeight;
                record.DimHeight = recordNew.DimHeight;
                record.DimWidth = recordNew.DimWidth;
                record.DimLength = recordNew.DimLength;
                record.DimVolume = recordNew.DimVolume;
                record.IndAllowChilds = recordNew.IndAllowChilds;
                record.IndAllowEdit = recordNew.IndAllowEdit;

                recordNew.Modifiedon = DateTime.Now;
                recordNew.Modifiedby = payload.username;
            }
            else
            {

                if (_db.V2MasterPackages.Any(f => f.PackageName == recordNew.PackageName))
                    throw new Exception($"Registro ya existe en la plataforma. Registration already exists on the platform.");


                recordNew.Createdon = DateTime.Now;
                recordNew.Createdby = payload.username;
            }

            if (exists)
            {
                _db.V2MasterPackages.Update(record);
            }
            else
            {
                _db.V2MasterPackages.Add(recordNew);
            }

            await _db.SaveChangesAsync();

            var response = new
            {
                Result = "OK",
                Message = "",
                Data = recordNew.PackageName
            };

            return response;
        }


    }
}
