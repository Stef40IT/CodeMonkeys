using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using Monkey.Core.Projections.Games;
using Monkey.Data;
using Monkey.Data.Data.Entities;
using Monkey.Data.Data.Repositories;

namespace Monkey.Core.Services.GameServices
{
    public class GameService : BaseService<Game>, IGameService
    {
        private readonly ApplicationDbContext _context;
        public GameService(ApplicationDbContext dbContext)
            : base()
        {
            _context = dbContext;
        }

        public async Task<Game> GetByName(string name)
        {
            return await _context.Games.FirstOrDefaultAsync(g => g.Name == name);
        }
    }
}
