using Monkey.Core.Projections.Games;
using Monkey.Data.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Core.Services.FavoriteServices
{
    public interface IFavoriteService
    {
        Task<List<Game>> GetFavoriteGamesAsync(string userId);
        Task AddToFavoritesAsync(string userId, int gameId);
        Task RemoveFromFavoritesAsync(string userId, int gameId);
        Task<bool> Contains(int gameId, string userId);
        public Task<List<GameGeneralInfoProjection>> GetFavProj(string userId);
        public Task<List<Favorite>> GetFav(string userId);
    }
}
