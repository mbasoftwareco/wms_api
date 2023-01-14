using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using wms_api.Services;
using System.ComponentModel.DataAnnotations;
using wms_api.Helpers;
using Microsoft.AspNetCore.Cors;

namespace wms_api.Controllers.v1
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private IUserService _userService; 

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost]
        [EnableCors("_anyCors")]
        [Route("SignIn")]
        public async Task<IActionResult> Post([FromBody] LoginModel apiUser)
        {
            var user = await _userService.Authenticate(apiUser.email, apiUser.password);

            if (user == null)
                return BadRequest(new { errors = "USER_PASSWD_INCORRECT" , Message = "USER_PASSWD_INCORRECT" });

            var userConfig = _userService.GetUserConfig(user);

            return Ok(userConfig);

        }

    }

    public class LoginModel
    {
        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }
    }

}
