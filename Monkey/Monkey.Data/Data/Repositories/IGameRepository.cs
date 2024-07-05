using Monkey.Data.Data.Entities;

namespace Monkey.Data.Data.Repositories
{
    public interface IGameRepository
    {
        public void Create(Game entity);
        public void Delete(Game entity);
        public Game? Get(string name);
    }
}