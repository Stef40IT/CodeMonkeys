using Monkey.Data.Data.Sorting;
using Monkey.Data.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Data.Data.Repositories
{
    public class ReservationRepo : IReservationRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ReservationRepo(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public void Create(Reservation entity)
        {
            this._dbContext.Reservations.Add(entity);
            this._dbContext.SaveChanges();
        }

        public void Delete(Reservation entity)
        {
            this._dbContext.Set<Reservation>().Remove(entity);
            this._dbContext.SaveChanges();
        }

        public Reservation? Get(Expression<Func<Reservation, bool>> filter)
        {
            return this._dbContext.Set<Reservation>().Where(filter).FirstOrDefault();
        }

        public TProjection? Get<TProjection>(Expression<Func<Reservation, bool>> filter, Expression<Func<Reservation, TProjection>> projection)
        {
            return this._dbContext.Set<Reservation>().Where(filter).Select(projection).FirstOrDefault();
        }

        public Reservation? GetComplete(Expression<Func<Reservation, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetMany(Expression<Func<Reservation, bool>> filter)
        {
            return this._dbContext.Set<Reservation>().Where(filter).ToList();
        }

        public IEnumerable<TProjection> GetMany<TProjection>(Expression<Func<Reservation, bool>> filter, Expression<Func<Reservation, TProjection>> projection)
        {
            return this._dbContext.Set<Reservation>().Where(filter).Select(projection).ToList();
        }

        public IEnumerable<TProjection> GetMany<TProjection>(Expression<Func<Reservation, bool>> filter, Expression<Func<Reservation, TProjection>> projection, IEnumerable<IOrderClause<Reservation>> orderClauses)
        {
            throw new NotImplementedException();
            //return  _dbContext.Set<TEntity>().Where(filter).OrderBy(orderClauses).Select(projection).ToList();
        }

        public Reservation? GetWithNavigations(Expression<Func<Reservation, bool>> filter, IEnumerable<string> navigations)
        {
            throw new NotImplementedException();
        }

        public void Update(Reservation entity)
        {
            this._dbContext.Set<Reservation>().Update(entity);
            this._dbContext.SaveChanges();
        }
    }
}
