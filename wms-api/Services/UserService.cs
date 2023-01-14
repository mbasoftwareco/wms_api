using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wms_api.Models;
using wms_api.Utils;

namespace wms_api.Services
{
    public interface IUserService
    {
        Task<SUsuario> Authenticate(string username, string password);
        dynamic GetUserConfig(SUsuario curUser);
    }

    public class UserService : IUserService
    {
        private WMS_LIGERO_LIVEContext _db = new WMS_LIGERO_LIVEContext();

        private List<SUsuario> _users = (new WMS_LIGERO_LIVEContext()).SUsuarios.ToList();

        public async Task<SUsuario> Authenticate(string username, string password)
        {


            //Encriptar las clave para compararla

            // wrapped in "await Task.Run" to mimic fetching user from a db
            string cryptPasswd = UtilTool.CryptPasswd(password, Constantes.CryptString);
            //var user = await Task.Run(() => _db.SUsuarios.SingleOrDefault(x => x.NombreUsuario == username));  // && x.Clave == cryptPasswd

            // que el logueo funcione con unsername(email) o con el rowid
            var user = await Task.Run(() => _db.SUsuarios.SingleOrDefault(x => (x.NombreUsuario == username || x.Email == username || x.Rowid.ToString() == username) && x.Clave == cryptPasswd));


            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so return user details
            return user;
        }


        public dynamic GetUserConfig(SUsuario curUser)
        {
            DataSet ds = (new _WEB()).sp_Auth("USERCONFIG", curUser);
            var authToken = Encoding.ASCII.GetBytes($"{curUser.Email}:{UtilTool.DeCryptPasswd(curUser.Clave, Constantes.CryptString)}");
            return new { user = ds.Tables[0], menu = ds.Tables[1], sites = ds.Tables[2], setup = ds.Tables[3], api_token = Convert.ToBase64String(authToken) };
        }

    }
}
