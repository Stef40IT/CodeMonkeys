using Monkey.Data.Data.Entities;
using Monkey.Data.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Core.Services
{
    public class BaseService<TEntity> : IService<TEntity>
        where TEntity : class, IIdentifiable
    {
        protected BaseService(IRepository<TEntity> repository)
        {
            Repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        protected IRepository<TEntity> Repository { get; }
        public bool Create(TEntity entity)
        {
            if (!IsValid(entity)) return false;

            Repository.Create(entity);
            return true;
        }

        public bool Delete(int id)
        {
            var entity = Repository.Get(x => x.Id == id);
            if (entity is null) return false;

            Repository.Delete(entity);
            return true;
        }

        public bool Update(TEntity entity)
        {
            if (!IsValid(entity)) return false;

            Repository.Update(entity);
            return true;
        }

        public TEntity? GetById(int id)
        {
            return Repository.Get(g => g.Id == id);
        }


        protected virtual bool IsValid(TEntity entity) => true;
    }
}
