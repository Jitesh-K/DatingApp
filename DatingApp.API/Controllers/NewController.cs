using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetValues()
        {
            
            return Ok();
        }
    }
}