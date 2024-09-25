﻿using Entities.Models;
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

        //Add item
        public async Task AddAsync(Badge badge)
        {
            _context.Badges.Add(badge);
            await _context.SaveChangesAsync();
        }
    }
}
