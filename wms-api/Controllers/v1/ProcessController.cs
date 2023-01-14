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
    public class ProcessController : ControllerBase
    {

        private IConfiguration Configuration;
        private string CurrentUser;


        public ProcessController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        [EnableCors("_anyCors")]
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] ProcessRequest payload)
        {
            try
            {
                payload.username = UtilTool.GetCurrentUser(Request.Headers["Authorization"]);

                switch (payload.process)
                {

                    case "SHIPPING":
                        ShippingHelper shipHelper = new ShippingHelper(this.Configuration);
                        var result = await shipHelper.ShippingAction(payload);
                        return  Ok(result);

                    case "DELIVERY":
                        DeliveryHelper deliveryHelper = new DeliveryHelper(this.Configuration);
                        return Ok(await deliveryHelper.DeliveryAction(payload));

                    case "DELIVERY_LOCAL":
                        DeliveryLocalHelper deliveryLocalHelper = new DeliveryLocalHelper(this.Configuration);
                        return Ok(await deliveryLocalHelper.DeliveryLocalAction(payload));

                    case "TODO":
                        return Ok();

                    case "DEVICE_SCAN":
                        return Ok();

                    case "RECEIVING":
                        ReceivingHelper rcvHelper = new ReceivingHelper(this.Configuration);
                        var result_rcv = await rcvHelper.ReceivingAction(payload);
                        return Ok(result_rcv);

                    case "COUNT":
                        return Ok();

                    case "DATA_CAPTURE":
                        DataCaptureHelper dataHelper = new DataCaptureHelper(this.Configuration);
                        return Ok(await dataHelper.Action(payload));

                    case "INVENTORY":
                        InventoryHelper inventoryHelper = new InventoryHelper(this.Configuration);
                        return Ok(await inventoryHelper.Action(payload));

                    case "REPORTS":
                        ReportHelper reportsHelper = new ReportHelper(this.Configuration);
                        return Ok(await reportsHelper.GetReport(payload));

                    case "INTEGRATION":
                        IntegrationHelper intHelper = new IntegrationHelper(this.Configuration);
                        return Ok(await intHelper.Action(payload));

                    default: return Ok(await ActionDefault(payload));



                }

                return Ok();

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
                payload.username = UtilTool.GetCurrentUser(Request.Headers["Authorization"]);

                switch (payload.process)
                {
                    case "SHIPPING":
                        ShippingHelper shipHelper = new ShippingHelper(this.Configuration);
                        var result = await shipHelper.ShippingAction(payload);
                        return Ok(result);

                    case "DELIVERY":
                        DeliveryHelper deliveryHelper = new DeliveryHelper(this.Configuration);
                        return Ok(await deliveryHelper.DeliveryAction(payload));

                    case "TODO":
                        return Ok();

                    case "DEVICE_SCAN":
                        return Ok();

                    case "RECEIVING":
                        ReceivingHelper rcvHelper = new ReceivingHelper(this.Configuration);
                        var result_rcv = await rcvHelper.ReceivingAction(payload);
                        return Ok(result_rcv);

                    case "COUNT":
                        return Ok();

                    case "REPORT":
                        ReportHelper reportHelper = new ReportHelper(this.Configuration);
                        return Ok(await reportHelper.ReportAction(payload));

                    case "INTEGRATION":
                        IntegrationHelper intHelper = new IntegrationHelper(this.Configuration);
                        return Ok(await intHelper.Action(payload));

                    case "INVENTORY":
                        InventoryHelper inventoryHelper = new InventoryHelper(this.Configuration);
                        return Ok(await inventoryHelper.Action(payload));

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

        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<dynamic> ActionDefault(ProcessRequest payload)
        {
            switch (payload.action)
            {
                default:

                    WH_Obj curWMSObject = new WH_Obj
                    {
                        USERNAME = payload.username,
                        DOCUMENT = payload.document,
                        SITE = payload.site,
                        DATA_CAPTURED = payload.data_captured,
                        STEP = payload.step
                    };
                    return (new _WEB(this.Configuration)).sp_Default(payload.process, payload.action, curWMSObject);

            }

        }
    }
}
