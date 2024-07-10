using Microsoft.EntityFrameworkCore;
using Monkey.Core.Services.GameServices;
using Monkey.Data;
using Monkey.Data.Data.Entities;
using Monkey.Data.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Core.Services.ReservatioService
{
    public class ReservationService : IReservationService
    {
        private readonly ApplicationDbContext _dbContext;
        public ReservationService(ApplicationDbContext dbContext)
            : base()
        {
            _dbContext = dbContext;
        }

        public async void Create(Reservation entity)
        {
                _dbContext.Reservations.Add(entity);
                await _dbContext.SaveChangesAsync(); 
        }

        public List<Reservation> GetReservations(int? gameId, string userId)
        {
            return _dbContext.Reservations.Where(r => r.UserId == userId && r.GameId == gameId).ToList();
        }

        public async void Update(Reservation entity)
        {
            entity.ReturnDate = DateTime.Now;
            await _dbContext.SaveChangesAsync();
        }

        public bool isBooked(ref List<Reservation> reservations, string userId, int? gameId)
        {
            foreach (Reservation entity in reservations)
            {
                Reservation reservation = entity;
                if((DateTime.Now < entity.ReturnDate && DateTime.Now > entity.BookDate) && entity.UserId == userId && entity.GameId == gameId)
                {
                    reservations.Clear();
                    reservations.Add(reservation);   
                    return true;
                }
            }
            return false;
        }
    }
}
