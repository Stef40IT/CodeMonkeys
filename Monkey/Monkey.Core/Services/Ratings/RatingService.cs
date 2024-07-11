using Microsoft.EntityFrameworkCore;
using Monkey.Data;
using Monkey.Data.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Core.Services.Ratings
{
    public class RatingService:IRatingService
    {
        private readonly ApplicationDbContext _context;

        public RatingService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddRatingAsync(Rating rating)
        {
            _context.Ratings.Add(rating);
            await _context.SaveChangesAsync();

        }
        public async Task<Rating> GetRatingByUserAndGameAsync(string userId, int gameId)
        {
            return await _context.Ratings.FirstOrDefaultAsync(r => r.UserId == userId && r.GameId == gameId);
        }
        public async Task<List<Rating>> GetRatingsByGameAsync(int gameId)
        {
            return await _context.Ratings.Where(r => r.GameId == gameId).ToListAsync();
        }
    }
}
