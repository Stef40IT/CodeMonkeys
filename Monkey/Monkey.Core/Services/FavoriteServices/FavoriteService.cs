using Monkey.Data.Data.Entities;
using Monkey.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monkey.Core.Projections.Games;
using Microsoft.EntityFrameworkCore;

namespace Monkey.Core.Services.FavoriteServices
{
    public class FavoriteService : IFavoriteService
    {
        private readonly ApplicationDbContext _context;

        public FavoriteService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Game>> GetFavoriteGamesAsync(int userId)
        {
            return await _context.Favorites
                .Where(f => f.UserId == userId)
                .Select(f => f.Game).ToListAsync();
        }

        public async Task AddToFavoritesAsync(int userId, int gameId)
        {
            var favorite = new Favorite { UserId = userId, GameId = gameId };
            _context.Favorites.Add(favorite);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveFromFavoritesAsync(int userId, int gameId)
        {
            var favorite = await _context.Favorites
                .FirstOrDefaultAsync(f => f.UserId == userId && f.GameId == gameId);
            if (favorite != null)
            {
                _context.Favorites.Remove(favorite);
                await _context.SaveChangesAsync();
            }
        }
    }

}
