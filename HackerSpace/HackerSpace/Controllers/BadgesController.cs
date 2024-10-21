using Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HackerSpace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BadgesController : ControllerBase
    {
        private readonly IBadgesDAL _dal;

        public BadgesController(IBadgesDAL dal)
        {
            _dal = dal;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _dal.GetAllAsync());
        }
    }
}

