using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Core.Services
{
    public interface IService<TEntity>
        where TEntity : class
    {
        TEntity? GetById(int id);
        bool Create(TEntity entity);
        bool Delete(int Id);
        bool Update(TEntity entity);
    }
}
