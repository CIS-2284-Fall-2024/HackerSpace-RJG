using Entities.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace HackerSpace.Data.DALs
{
    public class BadgesDAL : IBadgesDAL
    {
        private ApplicationDbContext _context;

        public BadgesDAL(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<List<Badge>> GetAllAsync()
        {
            return await _context.Badges.ToListAsync();
        }

        public async Task<Badge?> GetBadgeAsync(Guid id)
        {
            var existingBadge = await _context.Badges.Where(b => b.Id == id).FirstOrDefaultAsync();
            return existingBadge;
        }

        public async Task AddAsync(Badge badge)
        {
            _context.Badges.Add(badge);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var existingBadge = await _context.Badges.Where(b => b.Id == id).FirstOrDefaultAsync();
            if (existingBadge != null)
            {
                _context.Remove(existingBadge);
            }
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Badge? badge)
        {
            //find the original in the list
            var existingBadge = await _context.Badges.Where(b => b.Id == badge!.Id).FirstOrDefaultAsync();

            if (existingBadge != null)
            {
                //assign the new entity properties into the old one
                existingBadge.Title = badge?.Title;
                existingBadge.Description = badge?.Description;
                existingBadge.Task = badge?.Task;
                existingBadge.TurninInstructions = badge?.TurninInstructions;
                existingBadge.ImagePath = badge?.ImagePath;
                //save changes
                await _context.SaveChangesAsync();
            }
            else
            {
                //TODO: Handle badge not found error
            }
        }
    }
}
