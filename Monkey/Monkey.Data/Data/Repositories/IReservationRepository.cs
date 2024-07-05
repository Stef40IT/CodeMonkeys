using Monkey.Data.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Data.Data.Repositories
{
    public interface IReservationRepository
    {
        public void Create(Reservation entity);
        public void Update(Reservation entity);
        public void Delete(Reservation entity);
    }
}
