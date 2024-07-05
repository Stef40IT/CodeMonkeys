using Monkey.Data.Data.Sorting;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Monkey.Data.Data.Entities;
using System.Threading.Tasks;

namespace Monkey.Data.Data.Repositories
{
    public class GameRepostory : IGameRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public GameRepostory(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public void Create(Game entity)
        {
            _dbContext.Games.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Game entity)
        {
            _dbContext.Games.Remove(entity);
            _dbContext.SaveChanges();
        }

        public Game? Get(string name)
        {
            return _dbContext.Games.Where(g => g.Name == name).FirstOrDefault();
        }
    }
}
