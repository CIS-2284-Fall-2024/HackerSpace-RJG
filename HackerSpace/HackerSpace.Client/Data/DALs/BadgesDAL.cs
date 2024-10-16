using Entities.Interfaces;
using Entities.Models;

namespace HackerSpace.Data.DALs
{
    public class BadgesDAL : IBadgesDAL
    {
        public Task AddAsync(Badge badge)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Badge>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Badge?> GetBadgeAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Badge? badge)
        {
            throw new NotImplementedException();
        }
    }
}
