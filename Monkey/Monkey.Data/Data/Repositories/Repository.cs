using Monkey.Data.Data.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Data.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private readonly ApplicationDbContext _dbContext;
        public Repository(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public void Create(TEntity entity)
        {
            this._dbContext.Set<TEntity>().Add(entity);
            this._dbContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            this._dbContext.Set<TEntity>().Remove(entity);
            this._dbContext.SaveChanges();
        }

        public TEntity? Get(Expression<Func<TEntity, bool>> filter)
        {
            return this._dbContext.Set<TEntity>().Where(filter).FirstOrDefault();
        }

        public TProjection? Get<TProjection>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TProjection>> projection)
        {
            return this._dbContext.Set<TEntity>().Where(filter).Select(projection).FirstOrDefault();
        }

        public TEntity? GetComplete(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }
        
        public IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> filter)
        {
            return this._dbContext.Set<TEntity>().Where(filter).ToList();
        }

        public IEnumerable<TProjection> GetMany<TProjection>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TProjection>> projection)
        {
            return this._dbContext.Set<TEntity>().Where(filter).Select(projection).ToList();
        }

        public IEnumerable<TProjection> GetMany<TProjection>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TProjection>> projection, IEnumerable<IOrderClause<TEntity>> orderClauses)
        {
            throw new NotImplementedException();
            //return _dbContext.Set<TEntity>().Where(filter).OrderBy(orderClauses).Select(projection).ToList();
        }

        public TEntity? GetWithNavigations(Expression<Func<TEntity, bool>> filter, IEnumerable<string> navigations)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            this._dbContext.Set<TEntity>().Update(entity);
            this._dbContext.SaveChanges();  
        }

        public ApplicationDbContext GetDb() { return this._dbContext; }
    }
}
