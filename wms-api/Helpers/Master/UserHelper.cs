using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using wms_api.Models;
using wms_api.Utils;
using wms_api.Wrappers;

namespace wms_api.Helpers
{
    public class UserHelper
    {

        private IConfiguration Configuration;
        private string CurrentUser;

        private WMS_LIGERO_LIVEContext _db = new WMS_LIGERO_LIVEContext();

        public UserHelper() { }

        public UserHelper(IConfiguration _configuration)
        {
            this.Configuration = _configuration;
            this._db = new WMS_LIGERO_LIVEContext();
        }


        public async Task<dynamic> Get(string id)
        {
            var record = _db.SUsuarios.Where(f => f.Email == id).FirstOrDefault();

            if (record == null)
            {
                throw new Exception("Not Found.");
            }

            List<SRolesUsuario> roles = new List<SRolesUsuario>();

            roles.Add(_db.SRolesUsuarios.FirstOrDefault(x => x.RowidUsuario == record.Rowid));

            record.SRolesUsuarios = roles;

            record.SUsuariosEntidades = _db.SUsuariosEntidades.Where(x => x.RowidUsuario == record.Rowid && x.IdTipoEntidad == "SITES").ToList();

            return record;
        }

        public async Task<dynamic> Post(SUsuario recordNew, MasterRequest payload)
        {

            SUsuario record = _db.SUsuarios.FirstOrDefault(c => c.Email == recordNew.Email);

            bool indActivo = payload.data.indActivo;

            if (record != null)
            {
                record.NombreCompleto = recordNew.NombreCompleto;

                record.Identificacion = recordNew.Identificacion;

                record.ErpCodigo = recordNew.ErpCodigo;

                record.IndActivo = payload.data.indActivo;

                record.Idioma = recordNew.Idioma;

                record.Fechamod = DateTime.Now;

                record.Usuariomod = payload.username;

                _db.SUsuarios.Update(record);

                int idRol = payload.data.rol;

                List<SRolesUsuario> oldRoles = _db.SRolesUsuarios.Where(x => x.RowidRol != idRol && x.RowidUsuario == record.Rowid).ToList();

                foreach(SRolesUsuario rol in oldRoles)
                {
                    _db.SRolesUsuarios.Remove(rol);
                }

                await _db.SaveChangesAsync();


                SRolesUsuario userRol = _db.SRolesUsuarios.FirstOrDefault(x => x.RowidRol == idRol && x.RowidUsuario == record.Rowid);

                if (userRol == null)
                {
                    userRol = new SRolesUsuario
                    {
                        RowidRol = idRol,
                        RowidUsuario = record.Rowid,
                        Fechacreacion = DateTime.Now,
                        Usuariocreacion = payload.username,
                        RowidEmpresa = 4,
                    };

                    _db.SRolesUsuarios.Add(userRol);

                    await _db.SaveChangesAsync();
                }

                dynamic sites = payload.data.site;

                List<SUsuariosEntidade> oldSites = _db.SUsuariosEntidades.Where(x => x.RowidUsuario == record.Rowid).ToList();

                bool exists = false;

                foreach(SUsuariosEntidade site in oldSites)
                {
                    foreach (string site_ in sites)
                    {
                        if (site_.ToUpper() == site.ValorEntidad.ToUpper()) {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                        _db.SUsuariosEntidades.Remove(site);
                }

                await _db.SaveChangesAsync();

                foreach (var site in sites)
                {
                    string tmpSite = site.ToString().ToUpper();

                    SUsuariosEntidade userSite = _db.SUsuariosEntidades.FirstOrDefault(x => x.ValorEntidad.ToUpper() == tmpSite);

                    if(userSite == null)
                    {
                        userSite = new SUsuariosEntidade
                        {
                            ValorEntidad = tmpSite,
                            Fechacreacion = DateTime.Now,
                            Usuariocreacion = payload.username,
                            RowidUsuario = record.Rowid,
                            IdTipoEntidad = "SITES",
                            ErpIdCia = 1,
                            IndPrincipal = true,
                            RowidEmpresa = 4,
                        };

                        _db.SUsuariosEntidades.Add(userSite);
                    }
                }

                await _db.SaveChangesAsync();

            }
            else
            {
                if (_db.SUsuarios.Any(f => f.Email == recordNew.Email))
                    throw new Exception($"Registro ya existe en la plataforma. Registration already exists on the platform.");

                recordNew.Fechacreacion = DateTime.Now;
            }

            var response = new
            {
                Result = "OK",
                Message = "",
                Data = recordNew.Email
            };

            return response;
        }

        public async Task<dynamic> RegisterUser(ProcessRequest payload)
        {
            dynamic data = JsonConvert.DeserializeObject(payload.data_captured);

            data = data["record"];

            string email = data["email"];

            int rol = 0;

            try
            {
                rol = data["rol"];
            }
            catch
            {

            }

            string identificacion = data["identificacion"];


            string nombreCompleto = data["nombreCompleto"];

            if (string.IsNullOrEmpty(nombreCompleto))
                nombreCompleto = data["nombre_completo"];

            string idioma = data["idioma"];

            string erpCodigo = data["erpCodigo"];

            short indActivo = 1;

            try
            {
                bool active = data["indActivo"];

                if (active == true)
                {
                    indActivo = 1;
                }
                else
                {
                    indActivo = 0;
                }
            }
            catch
            {

            }

            string clave = "";

            try
            {
                string tmpClave = data["password"];

                clave = UtilTool.CryptPasswd(tmpClave, Constantes.CryptString);
            }
            catch (Exception e)
            {

            }

            bool exists = false;

            SUsuario record = _db.SUsuarios.FirstOrDefault(c => c.Email == email);

            string Guid = "WMS-" + UtilTool.ReturnGUID(8);

            if (record != null)
            {
                exists = true;

                record.Fechamod = DateTime.Now;

                record.IndActivo = indActivo;

                record.Usuariomod = payload.username;

                record.Identificacion = identificacion;

                record.NombreCompleto = nombreCompleto;

                record.ErpCodigo = erpCodigo;

                record.Idioma = idioma;

                //if (record.Clave.StartsWith("WMS-") && !string.IsNullOrEmpty(clave))
                    record.Clave = clave;
            }
            else
            {

                record = new SUsuario();

                record.Email = email;

                record.NombreUsuario = email;

                //record.Clave = "";

                record.IndActivo = -1;

                record.RowidEmpresa = 4;

                record.Fechacreacion = DateTime.Now;

                record.Usuariocreacion = payload.username;

                record.Clave = Guid;

            }

            if (record != null)
            {

                if (exists)
                {
                    _db.SUsuarios.Update(record);
                }
                else
                {
                    _db.SUsuarios.Add(record);

                    await _db.SaveChangesAsync();

                    //Envio del mail
                    Notification.GetDataNotification("REGISTER_USER", record.Email, Guid);

                }

                await _db.SaveChangesAsync();

            }

            exists = false;

            SRolesUsuario rolUsuario = _db.SRolesUsuarios.FirstOrDefault(x => x.RowidRol == rol && x.RowidUsuario == record.Rowid);

            if (rolUsuario != null)
            {
                exists = true;

                rolUsuario.Fechamod = DateTime.Now;

                rolUsuario.Usuariomod = payload.username;

            }
            else if (rol != 0)
            {
                rolUsuario = new SRolesUsuario();

                rolUsuario.RowidRol = rol;

                rolUsuario.RowidUsuario = record.Rowid;

                rolUsuario.RowidEmpresa = 4;

                rolUsuario.Fechacreacion = DateTime.Now;

                rolUsuario.Usuariocreacion = payload.username;

            }

            if (rolUsuario != null)
            {
                if (exists)
                {
                    _db.SRolesUsuarios.Update(rolUsuario);
                }
                else
                {
                    _db.SRolesUsuarios.Add(rolUsuario);
                }

                await _db.SaveChangesAsync();

            }


            var response = new
            {
                Result = "OK",
                Message = "",
                Data = ""
            };

            return response;
        }

        public async Task<dynamic> CreateUser(MasterRequest payload)
        {
            dynamic data = payload.data;

            data = data["record"];

            string email = data["email"];

            int rol = 0;

            try
            {
                rol = data["rol"];
            }
            catch
            {

            }

            string identificacion = data["identificacion"];


            string nombreCompleto = data["nombreCompleto"];

            if (string.IsNullOrEmpty(nombreCompleto))
                nombreCompleto = data["nombre_completo"];

            string idioma = data["idioma"];

            string erpCodigo = data["erpCodigo"];

            short indActivo = 1;

            try
            {
                bool active = data["indActivo"];

                if (active == true)
                {
                    indActivo = 1;
                }
                else
                {
                    indActivo = 0;
                }
            }
            catch
            {

            }

            string clave = "";

            try
            {
                string tmpClave = data["password"];

                clave = UtilTool.CryptPasswd(tmpClave, Constantes.CryptString);
            }
            catch (Exception e)
            {

            }

            bool exists = false;

            SUsuario record = _db.SUsuarios.FirstOrDefault(c => c.Email == email);

            string Guid = "WMS-" + UtilTool.ReturnGUID(8);

            if (record != null)
            {
                exists = true;

                record.Fechamod = DateTime.Now;

                record.IndActivo = indActivo;

                record.Usuariomod = payload.username;

                record.Identificacion = identificacion;

                record.NombreCompleto = nombreCompleto;

                record.ErpCodigo = erpCodigo;

                record.Idioma = idioma;

                if (record.Clave.StartsWith("WMS-") && !string.IsNullOrEmpty(clave))
                    record.Clave = clave;
            }
            else
            {

                record = new SUsuario();

                record.Email = email;

                record.NombreUsuario = email;

                //record.Clave = "";

                record.IndActivo = -1;

                record.RowidEmpresa = 4;

                record.Fechacreacion = DateTime.Now;

                record.Usuariocreacion = payload.username;

                record.Clave = Guid;

            }

            if (record != null)
            {

                if (exists)
                {
                    _db.SUsuarios.Update(record);
                }
                else
                {
                    _db.SUsuarios.Add(record);

                    await _db.SaveChangesAsync();

                    //Envio del mail
                    Notification.GetDataNotification("REGISTER_USER", record.Email, Guid);

                }

                await _db.SaveChangesAsync();

            }

            exists = false;

            SRolesUsuario rolUsuario = _db.SRolesUsuarios.FirstOrDefault(x => x.RowidRol == rol && x.RowidUsuario == record.Rowid);

            if (rolUsuario != null)
            {
                exists = true;

                rolUsuario.Fechamod = DateTime.Now;

                rolUsuario.Usuariomod = payload.username;

            }
            else if (rol != 0)
            {
                rolUsuario = new SRolesUsuario();

                rolUsuario.RowidRol = rol;

                rolUsuario.RowidUsuario = record.Rowid;

                rolUsuario.RowidEmpresa = 4;

                rolUsuario.Fechacreacion = DateTime.Now;

                rolUsuario.Usuariocreacion = payload.username;

            }

            if (rolUsuario != null)
            {
                if (exists)
                {
                    _db.SRolesUsuarios.Update(rolUsuario);
                }
                else
                {
                    _db.SRolesUsuarios.Add(rolUsuario);
                }

                await _db.SaveChangesAsync();

            }


            var response = new
            {
                Result = "OK",
                Message = "",
                Data = ""
            };

            return response;
        }

        public async Task<dynamic> ResetPasswordToken(ProcessRequest payload)
        {
            string email = payload.data_captured;

            SUsuario record = _db.SUsuarios.FirstOrDefault(c => c.Email == email && c.IndActivo == 1);

            string Guid = "WMS-" + UtilTool.ReturnGUID(8);

            if (record != null)
            {
                record.Fechamod = DateTime.Now;

                record.Usuariomod = email;

                record.ResetToken = Guid;

                _db.SUsuarios.Update(record);

                await _db.SaveChangesAsync();

                Notification.GetDataNotification("RESET_PASSWORD", record.Email, Guid);

            }
            else
                throw new Exception("USER_INCORRECT");



            var response = new
            {
                Result = "OK",
                Message = "Se le envió un mail con las instrucciones para cambiar su contraseña",
                Data = ""
            };

            return response;
        }

        public async Task<dynamic> ResetPassword(ProcessRequest payload)
        {

            dynamic data = JsonConvert.DeserializeObject(payload.data_captured);

            data = data["record"];

            string email = data["email"];

            string clave = "";

            try
            {
                string tmpClave = data["password"];

                clave = UtilTool.CryptPasswd(tmpClave, Constantes.CryptString);
            }
            catch (Exception e)
            {

            }

            SUsuario record = _db.SUsuarios.FirstOrDefault(c => c.Email == email);

            record.Clave = clave;

            record.ResetToken = null;

            _db.SUsuarios.Update(record);

            await _db.SaveChangesAsync();

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
