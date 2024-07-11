using Monkey.Data.Data.Entities;
using Monkey.Core.Projections.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monkey.Web.ViewModels.Game;

namespace Monkey.Core.Services.GameServices
{
    public interface IGameService : IService<Game>
    {
        Task<IEnumerable<GameGeneralInfoProjection>> GetAllGames();
        GameGeneralInfoProjection? GetOne(int id);
        GameEditProjection? GetOneEdit(int id);
        void AddGame(GameViewModel gameViewModel);
        public Task UpdateCountDown(Game entity);
        public Task UpdateCountUp(Game entity);
        void UpdateGame(GameViewModel gameViewModel, int id);
        public void UpdateCountDown(int id);
        public void UpdateCountUp(int id);
        public Task<Game> GetByName(string name);
        public Task<Game>? GetGameById(int? id);
    }
}
