﻿using Monkey.Data;
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
        public ReservationService(ApplicationDbContext reservationRepository)
            : base()
        {
            _dbContext = reservationRepository;
        }

        public void Create(Reservation entity)
        {
            _dbContext.Reservations.Add(entity);
        }
    }
}
