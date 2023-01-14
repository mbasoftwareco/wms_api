using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using wms_api.Models;
using wms_api.Wrappers;

namespace wms_api.Helpers
{
    public class CompanyHelper
    {

        private IConfiguration Configuration;

        private WMS_LIGERO_LIVEContext _db = new WMS_LIGERO_LIVEContext();

        public CompanyHelper() { }


        public CompanyHelper(IConfiguration _configuration)
        {
            this.Configuration = _configuration;
            this._db = new WMS_LIGERO_LIVEContext();
        }



        public async Task<dynamic> Get(string id)
        {
            var record = _db.MEmpresas.Where(f => f.Rowid.ToString() == id).FirstOrDefault();

            if (record == null)
            {
                throw new Exception("Not Found.");
            }

            return record;
        }


        public async Task<dynamic> Post(MEmpresa recordNew, MasterRequest payload)
        {


            bool exists = false;

            MEmpresa record = _db.MEmpresas.FirstOrDefault(c => c.Rowid == recordNew.Rowid);

            if (record != null)
            {
                exists = true;

                record.Identificacion = recordNew.Identificacion;
                record.Razonsocial = recordNew.Razonsocial;
                record.Pais = recordNew.Pais;
                record.Estado = recordNew.Estado;
                record.Ciudad = recordNew.Ciudad;
                record.Direccion1 = recordNew.Direccion1;
                record.Direccion2 = recordNew.Direccion2;
                record.Telefono1 = recordNew.Telefono1;
                record.Telefono2 = recordNew.Telefono2;
                record.CodPostal = recordNew.CodPostal;


                record.Fechamod = DateTime.Now;
                record.Usuariomod = payload.username;
            }
            else
            {

                if (_db.MEmpresas.Any(f => f.Identificacion == recordNew.Identificacion))
                    throw new Exception($"Registro ya existe en la plataforma. Registration already exists on the platform.");


                recordNew.Fechacreacion = DateTime.Now;
                recordNew.Usuariocreacion = payload.username;
            }

            if (exists)
            {
                _db.MEmpresas.Update(record);
            }
            else
            {
                _db.MEmpresas.Add(recordNew);
            }

            await _db.SaveChangesAsync();

            var response = new
            {
                Result = "OK",
                Message = "",
                Data = recordNew.Identificacion
            };

            return response;
        }


    }
}