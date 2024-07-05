using Monkey.Data.Data.Entities;
using Monkey.Data.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Core.Services.ReservatioService
{
    public interface IReservationService
    {
        public void Create(Reservation entity);

    }
}
