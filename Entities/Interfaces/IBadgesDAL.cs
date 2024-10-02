using Entities.Models;

namespace Entities.Interfaces
{
    public interface IBadgesDAL
    {
        public Task<List<Badge>> GetAllAsync();
        public Task<Badge?> GetBadgeAsync(Guid id);
        public Task AddAsync(Badge badge);
        public Task UpdateAsync(Badge? badge);
    }
}
