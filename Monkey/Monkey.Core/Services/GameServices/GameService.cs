using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Monkey.Core.Projections.Games;
using Monkey.Data;
using Monkey.Data.Data.Entities;
using Monkey.Data.Data.Repositories;

namespace Monkey.Core.Services.GameServices
{
    public class GameService : BaseService<Game>, IGameService
    {
        public GameService(IRepository<Game> repository)
            : base(repository)
        { }

        public async Task<IEnumerable<GameGeneralInfoProjection>> GetAllGames()
        {
            return Repository.GetMany(_ => true, g => new GameGeneralInfoProjection
            {
                Id = g.Id,
                Name = g.Name,
                Description = g.Description,
                Picture = g.Picture,
                Difficulty = g.Difficulty,
                Count = g.Count,
                Comments = g.Comments,
                Raitings = g.Raitings,
                Reservations = g.Reservations,
                isBooked = g.isBooked

            });
        }

        public GameGeneralInfoProjection? GetById(int id)
        {
            return Repository.Get(g => g.Id == id, g => new GameGeneralInfoProjection
            {
                Id = g.Id,
                Name = g.Name,
                Description = g.Description,
                Picture = g.Picture,
                Difficulty = g.Difficulty,
                Count = g.Count,
                Comments = g.Comments,
                Raitings = g.Raitings,
                Reservations = g.Reservations,
                isBooked = g.isBooked

            });

        }

        public GameGeneralInfoProjection? GetOne(int id)
        {
            return Repository.Get(g => g.Id == id, GetGeneralInfoInformation());
        }

        public GameEditProjection? GetOneEdit(int id)
        {
            return Repository.Get(g => g.Id == id, g => new GameEditProjection
            {
                Id = g.Id,
                Name = g.Name,
                Description = g.Description,
                Picture = g.Picture,
                Difficulty = g.Difficulty,
                Count = g.Count,
                Comments = g.Comments,
                Raitings = g.Raitings,
                Reservations = g.Reservations,
                isBooked = g.isBooked

            });
        }
        private Expression<Func<Game, GameGeneralInfoProjection>> GetGeneralInfoInformation()
        {
            return g => new GameGeneralInfoProjection
            {
                Id = g.Id,
                Name = g.Name,
                Description = g.Description,
                Picture = g.Picture,
                Difficulty = g.Difficulty,
                Count = g.Count,
                Comments = g.Comments,
                Raitings = g.Raitings,
                Reservations = g.Reservations,
                isBooked = g.isBooked

            };
        }
    }
}
