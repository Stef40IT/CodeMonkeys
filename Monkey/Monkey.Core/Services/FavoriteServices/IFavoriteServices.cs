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
        Task<List<Game>> GetFavoriteGamesAsync(int userId);
        Task AddToFavoritesAsync(int userId, int gameId);
        Task RemoveFromFavoritesAsync(int userId, int gameId);
    }
}
