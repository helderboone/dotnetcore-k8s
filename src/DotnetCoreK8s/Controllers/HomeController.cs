using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreK8s.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(long id)
        {
            return Ok(new { id });
        }
    }
}
