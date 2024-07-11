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
        public async Task<List<Game>> GetFavoriteGamesAsync(string userId)
        {
            return await _context.Favorites
                .Where(f => f.UserId == userId)
                .Select(f => f.Game).ToListAsync();
        }

        public async Task<List<Favorite>> GetFav(string userId)
        {
            return (_context.Favorites.Where(f => f.UserId == userId)).ToList();
        }

        public async Task AddToFavoritesAsync(string userId, int gameId)
        {
            var favorite = new Favorite { UserId = userId, GameId = gameId };
            _context.Favorites.Add(favorite);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveFromFavoritesAsync(string userId, int gameId)
        {
            var favorite = await _context.Favorites
                .FirstOrDefaultAsync(f => f.UserId == userId && f.GameId == gameId);
            if (favorite != null)
            {
                _context.Favorites.Remove(favorite);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<GameGeneralInfoProjection>> GetFavProj(string userId)
        {
            var favoriteList = _context.Favorites.Where(f => f.UserId == userId).Select(f => f.Game).ToList();
            var result = new List<GameGeneralInfoProjection>();
            foreach (Game f in favoriteList)
            {
                GameGeneralInfoProjection favGame = new GameGeneralInfoProjection
                {
                    Id = f.Id,
                    Name = f.Name,
                    Description = f.Description,
                    Picture = f.Picture,
                    Difficulty = f.Difficulty,
                    Count = f.Count,
                    Comments = f.Comments,
                    Raitings = f.Raitings,
                    Reservations = f.Reservations,
                    isBooked = f.isBooked
                };
                result.Add(favGame);
            }

            return result;
        }

        

        public async Task<bool> Contains(int gameId, string userId)
        {
            foreach (Favorite a in _context.Favorites.ToList())
            {
                if (a.GameId == gameId && a.UserId == userId) return true;
            }

            return false;
        }
    }

}
