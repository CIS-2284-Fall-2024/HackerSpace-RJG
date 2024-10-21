using Entities.Interfaces;
using Entities.Models;
using System;
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

        public async Task<Badge?> GetBadgeAsync(Guid id)
        {
            return await _http.GetFromJsonAsync<Badge?>($"api/Badges/{id.ToString()}");
        }

        public async Task AddAsync(Badge badge)
        {
            await _http.PostAsJsonAsync<Badge>($"api/Badges/{badge.Id}", badge);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _http.DeleteAsync($"api/Badges/{id.ToString()}");
        }

        public async Task UpdateAsync(Badge? badge)
        {
            if(badge == null)
            {
                throw new ArgumentNullException(nameof(badge)); 
            }
            await _http.PutAsJsonAsync<Badge>($"api/Badges", badge);
        }
    }
}
