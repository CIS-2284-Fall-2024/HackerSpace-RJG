using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackerSpace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BadgesController : ControllerBase
    {
        [HttpGet]
        public string GetAll()
        {
            return "Blah!";
        }
    }
}

