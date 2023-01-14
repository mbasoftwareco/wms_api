using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;
using wms_api.Helpers;
using wms_api.Models;
using wms_api.Utils;
using wms_api.Wrappers;

namespace wms_api.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {

        private IConfiguration Configuration;

        public RegisterController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }


        [EnableCors("_anyCors")]
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] ProcessRequest payload)
        {
            try
            {

                payload.username = "";// UtilTool.GetCurrentUser(Request.Headers["Authorization"]);

                /*if (!String.IsNullOrEmpty(payload.id_process))
                {

                    switch (payload.action)
                    {
                        case "":
                            BinHelper BinHelper = new BinHelper(this.Configuration);
                            int id = int.Parse(payload.id_process);
                            return Ok(await BinHelper.Get(id));

                        
                    }
                }*/

                WH_Obj curWMSObject = new WH_Obj
                {
                    USERNAME = payload.username,
                    SESSION_ID = payload.session_id,
                    SITE = payload.site
                };

                return Ok((new _WEB(this.Configuration)).sp_Master(payload.action, curWMSObject));
            }
            catch (Exception e)
            {
                return Problem(e.Message, payload.process, 500, null, null);
            }
        }


        [EnableCors("_anyCors")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProcessRequest payload)
        {
            try
            {
                payload.username = "";// UtilTool.GetCurrentUser(Request.Headers["Authorization"]);

                dynamic record = null;

                UserHelper UserHelper_;

                switch (payload.action)
                {
                    
                    case "USER_NEW":
                        UserHelper_ = new UserHelper(this.Configuration);
                        return Ok(await UserHelper_.RegisterUser(payload));

                    case "SET_RESET_PASSWORD_TOKEN":
                        UserHelper_ = new UserHelper(this.Configuration);
                        return Ok(await UserHelper_.ResetPasswordToken(payload));

                    case "RESET_PASSWORD":
                        UserHelper_ = new UserHelper(this.Configuration);
                        return Ok(await UserHelper_.ResetPassword(payload));

                    default:
                        break;
                }


                return Ok();

            }
            catch (Exception e)
            {
                return Problem(e.Message, payload.process, 500, null, null);
            }
        }

    }
}
