using ECOMM.Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECOMM.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        protected IActionResult StatusCode(Response response) 
        {
            return StatusCode(response.StatusCode, response);
        }
    }
}
