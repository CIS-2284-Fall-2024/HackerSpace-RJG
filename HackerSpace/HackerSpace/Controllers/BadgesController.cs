using Entities.Interfaces;
using Entities.Models;
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


        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id)
        {
            return Ok(await _dal.GetBadgeAsync(Guid.Parse(id)));
        }

        [HttpPost]
        public async Task PostAsync(Badge badge)
        {
            await _dal.AddAsync(badge);
        }

        [HttpPut]
        public async Task PutAsync(Badge badge)
        {
            await _dal.UpdateAsync(badge);
        }

        [HttpDelete]
        public async Task DeleteAsync(string id)
        {
            await _dal.DeleteAsync(Guid.Parse(id));
        }
    }
}

