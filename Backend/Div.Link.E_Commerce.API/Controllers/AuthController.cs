using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Div.Link.E_Commerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAction()
        {
            return Ok("AuthController is working!");
        }
    }
}
