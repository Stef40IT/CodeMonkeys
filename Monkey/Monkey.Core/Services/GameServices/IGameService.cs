using Monkey.Data.Data.Entities;
using Monkey.Core.Projections.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Core.Services.GameServices
{
    public interface IGameService : IService<Game>
    {
        public Task<Game> GetByName(string name);
        public List<Game> GetAll();
        public void UpdateCountDown(int id);
        public void UpdateCountUp(int id);

        //Task<IEnumerable<GameGeneralInfoProjection>> GetAllGames();
        //GameGeneralInfoProjection? GetOne(int id);
        //GameEditProjection? GetOneEdit(int id);
        //Game? GetOneByName(string name);
    }
}
