using Entities.Interfaces;
using Entities.Models;
using System.Net.Http.Json;

namespace HackerSpace.Client.Data.DALs
{
    public class ClientBadgesDAL : IBadgesDAL
    {
        private HttpClient _http;

        public ClientBadgesDAL(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Badge>> GetAllAsync()
        {
            //Send request on the web and get data as json
            //because I can't acces the sql server from a user's
            //browser.
            return await _http.GetFromJsonAsync<List<Badge>>("api/Badges") ?? new List<Badge>();

        }

        public Task<Badge?> GetBadgeAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Badge badge)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Badge? badge)
        {
            throw new NotImplementedException();
        }
    }
}
