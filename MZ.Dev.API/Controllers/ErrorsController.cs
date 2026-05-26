using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MZ.Dev.Talabat.API.Errors;

namespace MZ.Dev.Talabat.API.Controllers
{
    [Route("Errors/{code}")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorsController : ControllerBase
    {
        public ActionResult Error(int code)
        {          
           return   NotFound(new ApiResponse(404));
        }
    }
}
