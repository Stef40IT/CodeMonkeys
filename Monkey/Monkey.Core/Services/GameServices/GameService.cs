using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
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

        public List<Game> GetAll()
        {
            return _context.Games.ToList();
        }

        public async void UpdateCountDown(int id)
        {
            var entity = _context.Games.SingleOrDefault(g => g.Id == id);
            if (entity != null)
            {
                entity.Count -= 1;
                if (entity.Count == 0 && entity.isBooked == true)
                {
                    entity.isBooked = false;
                }
                await _context.SaveChangesAsync();
            }
        }
        public void UpdateCountUp(int id)
        {
            var entity = _context.Games.SingleOrDefault(g => g.Id == id);
            if (entity != null)
            {
                entity.Count += 1;
                if (entity.Count > 0 && entity.isBooked == false)
                { 
                    entity.isBooked = true;
                }
                _context.SaveChanges();
            }

            
        }
    }
}
