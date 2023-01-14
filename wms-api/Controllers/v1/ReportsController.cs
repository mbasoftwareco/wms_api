using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;
using wms_api.Helpers;
using wms_api.Utils;
using wms_api.Wrappers;

namespace wms_api.Controllers.v1
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {

        private IConfiguration Configuration;

        public ReportsController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }


        [EnableCors("_anyCors")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProcessRequest payload)
        {
            try
            {
                payload.username = UtilTool.GetCurrentUser(Request.Headers["Authorization"]);

                ReportHelper reportHelper = new ReportHelper(this.Configuration);
                return Ok(await reportHelper.ReportAction(payload));
                 

            }
            catch (Exception e)
            {
                return Problem(e.Message, payload.process, 500, null, null);
            }
        }


    }
}
