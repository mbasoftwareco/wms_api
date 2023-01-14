using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using wms_api.Helpers;
using wms_api.Models;
using wms_api.Utils;
using wms_api.Wrappers;

namespace wms_api.Controllers.v1
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {

        private IConfiguration Configuration;

        public MasterController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }


        [EnableCors("_anyCors")]
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] MasterRequest payload)
        {
            try
            {

                payload.username = UtilTool.GetCurrentUser(Request.Headers["Authorization"]);

                if (!String.IsNullOrEmpty(payload.id))
                {

                    switch (payload.action)
                    {
                        case "BIN":
                            BinHelper BinHelper = new BinHelper(this.Configuration);
                            int id = int.Parse(payload.id);
                            return Ok(await BinHelper.Get(id));

                        case "SITE":
                            SiteHelper SiteHelper = new SiteHelper(this.Configuration);
                            return Ok(await SiteHelper.Get(payload.id));

                        case "COMPANY":
                            CompanyHelper CompanyHelper = new CompanyHelper(this.Configuration);
                            return Ok(await CompanyHelper.Get(payload.id));

                        case "PACKAGE":
                            PackageHelper PackageHelper = new PackageHelper(this.Configuration);
                            return Ok(await PackageHelper.Get(payload.id));

                        case "DELIVERY_COMPANY":
                            DeliveryCompanyHelper DeliveryCompanyHelper = new DeliveryCompanyHelper(this.Configuration);
                            return Ok(await DeliveryCompanyHelper.Get(payload.id));

                        case "USER":
                            UserHelper UserHelper = new UserHelper(this.Configuration);
                            return Ok(await UserHelper.Get(payload.id));
                    }
                }

                WH_Obj curWMSObject = new WH_Obj
                {
                    USERNAME = payload.username,
                    SESSION_ID = payload.session_id,
                    SITE = payload.site,
                    DATA_CAPTURED = payload.data_captured
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
        public async Task<IActionResult> Post([FromBody] MasterRequest payload)
        {
            try
            {
                payload.username = UtilTool.GetCurrentUser(Request.Headers["Authorization"]);

                dynamic record = null;

                UserHelper UserHelper;

                switch (payload.action)
                {
                    case "BIN":
                        BinHelper BinHelper = new BinHelper(this.Configuration);
                        record = new MBin();
                        record = UtilTool.CloneObject(payload.data, record.GetType()) as MBin;
                        return Ok(await BinHelper.Post(record, payload));

                    case "SITE":
                        SiteHelper SiteHelper = new SiteHelper(this.Configuration);
                        record = new MSite();
                        record = UtilTool.CloneObject(payload.data, record.GetType()) as MSite;
                        return Ok(await SiteHelper.Post(record, payload));

                    case "COMPANY":
                        CompanyHelper CompanyHelper = new CompanyHelper(this.Configuration);
                        record = new MEmpresa();
                        record = UtilTool.CloneObject(payload.data, record.GetType()) as MEmpresa;
                        return Ok(await CompanyHelper.Post(record, payload));

                    case "PACKAGE":
                        PackageHelper PackageHelper = new PackageHelper(this.Configuration);
                        record = new V2MasterPackage();
                        record = UtilTool.CloneObject(payload.data, record.GetType()) as V2MasterPackage;
                        return Ok(await PackageHelper.Post(record, payload));

                    case "DELIVERY_COMPANY":
                        DeliveryCompanyHelper DeliveryCompanyHelper = new DeliveryCompanyHelper(this.Configuration);
                        record = new V2WmsDeliveryCompany();
                        record = UtilTool.CloneObject(payload.data, record.GetType()) as V2WmsDeliveryCompany;
                        return Ok(await DeliveryCompanyHelper.Post(record, payload));

                    case "USER":
                        UserHelper = new UserHelper(this.Configuration);
                        record = new SUsuario();
                        record = UtilTool.CloneObject(payload.data, record.GetType()) as SUsuario;
                        return Ok(await UserHelper.Post(record, payload));

                    case "CREATE_USER":
                        UserHelper = new UserHelper(this.Configuration);
                        return Ok(await UserHelper.CreateUser(payload));

                    case "RESET_PASSWORD":
                        ProcessRequest rq = new ProcessRequest();

                        rq.process = payload.process;

                        rq.data_captured = JsonConvert.SerializeObject(payload.data);

                        rq.action = payload.action;

                        UserHelper = new UserHelper(this.Configuration);
                        return Ok(await UserHelper.ResetPassword(rq));

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
