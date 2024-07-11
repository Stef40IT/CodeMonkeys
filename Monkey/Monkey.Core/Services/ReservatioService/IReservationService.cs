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
        public void Update(Reservation entity);
        public List<Reservation> GetReservations(int? gameId, string userId);
        public bool isBooked(ref List<Reservation> reservations, string userId, int? gameId);
    }
}
