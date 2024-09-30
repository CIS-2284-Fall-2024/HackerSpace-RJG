using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace HackerSpace.Data.DAL
{
    public class BadgesPageDAL
    {
        private readonly ApplicationDbContext _context;

        public BadgesPageDAL(ApplicationDbContext context)
        {
            _context = context;
        }

        //Get all
        public async Task<List<Badge>> GetAllAsync()
        {
            return await _context.Badges.ToListAsync();
        }

        //Get item
        public async Task<Badge?> GetByIdAsync(Guid id)
        {
            var badge =  await _context.Badges.Where(b=>b.Id == id).FirstOrDefaultAsync();
            return badge;
        }

        //Add item
        public async Task AddAsync(Badge badge)
        {
            _context.Badges.Add(badge);
            await _context.SaveChangesAsync();
        }

        //Update item
        public async Task UpdateAsync(Badge badge)
        {
            _context.Badges.Update(badge);
            await _context.SaveChangesAsync();
        }

        //Delete item
        public async Task DeleteAsync(Badge badge)
        {
            _context.Badges.Remove(badge);
            await _context.SaveChangesAsync();
        }
    }
}
