using Microsoft.AspNetCore.Mvc;

namespace Laba5MA.Controllers
{
    [Route("service1/api/v1/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<string>> GetAllPersonsAsync()
        {
            return Ok("Hello i service!");
        }
    }
}