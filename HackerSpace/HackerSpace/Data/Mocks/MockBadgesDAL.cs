using Entities.Interfaces;
using Entities.Models;

namespace HackerSpace.Data.Mocks
{
    public class MockBadgesDAL : IBadgesDAL
    {
        private List<Badge> badges;

        public MockBadgesDAL()
        {

            badges = new List<Badge>();

            for (int i = 0; i < 10; i++)
            {
                badges.Add(
                    new Badge()
                    {
                        Id = Guid.NewGuid(),
                        Title = $"Test title {i}",
                        Description = $"Test description{i}",
                        Task = $"Test task {i}",
                        TurninInstructions = $"Test instructions {i}",
                        ImagePath = $"/images/BasicGitBadge.png",
                    }
                );
            };
        }

        public async Task<Badge?> GetBadgeAsync(Guid id)
        {
            return await Task.FromResult(badges.Where(b => b.Id == id).FirstOrDefault());
        }

        public Task AddAsync(Badge badge)
        {
            badges.Add(badge);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Badge? badge)
        {
            //find the original in the list
            var existingBadge = badges.Where(b => b.Id == badge?.Id).FirstOrDefault();

            if (existingBadge != null)
            {
                //assign the new entity properties into the old one
                existingBadge.Title = badge?.Title;
                existingBadge.Description = badge?.Description;
                existingBadge.Task = badge?.Task;
                existingBadge.TurninInstructions = badge?.TurninInstructions;
                existingBadge.ImagePath = badge?.ImagePath;
                //save changes if required Not needed for List in Mock
            }
            else
            {
                //TODO: Handle badge not found error
            }

            return Task.CompletedTask;
        }

        public Task<List<Badge>> GetAllAsync()
        {
            return Task.FromResult(badges);
        }

        public Task DeleteAsync(Guid id)
        {
            //find the original in the list
            var existingBadge = badges.Where(b => b.Id == id).FirstOrDefault();

            if (existingBadge != null)
            {
                badges.Remove(existingBadge);
            }
            return Task.CompletedTask;
        }
    }
}
