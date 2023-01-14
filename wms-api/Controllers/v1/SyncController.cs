using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using wms_api.Helpers;
using wms_api.Wrappers;

namespace wms_api.Controllers.v1
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SyncController : ControllerBase
    {

        private IConfiguration Configuration;


        public SyncController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }


        [EnableCors("_anyCors")]
        [HttpPost]
        public IActionResult Post([FromBody] SyncRequest payload)
        {
            SyncHelper syncHelper = new SyncHelper(this.Configuration);
            return Ok(syncHelper.SyncAction(payload));
        }

        [EnableCors("_anyCors")]
        [HttpPost]
        [Route("Array")]
        public IActionResult SyncArray([FromBody] List<SyncRequest> payload)
        {
            SyncHelper syncHelper = new SyncHelper(this.Configuration);

            foreach (SyncRequest curPayload in payload)
            {
                try
                {
                    if (curPayload.document_info != null)
                    {
                        curPayload.document_info = JObject.Parse(curPayload.document_info);
                    }

                    syncHelper.SyncAction(curPayload);
                }
                catch (Exception ex) { }
            }

            return Ok();
        }

    }
}