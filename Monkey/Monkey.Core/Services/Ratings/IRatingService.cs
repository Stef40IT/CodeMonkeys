using Monkey.Data.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Core.Services.Ratings
{
    public interface IRatingService
    {
        Task AddRatingAsync(Rating rating);
        Task<Rating> GetRatingByUserAndGameAsync(string userId, int gameId);
        Task<List<Rating>> GetRatingsByGameAsync(int gameId);
        Task UpdateRatingAsync(Rating rating);

    }
}
