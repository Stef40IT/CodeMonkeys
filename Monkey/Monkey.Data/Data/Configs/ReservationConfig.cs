﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Data.Data.Configs
{
    public class ReservationConfig : IEntityTypeConfiguration<Entities.Reservation>
    {
        public void Configure(EntityTypeBuilder<Entities.Reservation> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.UserId).IsRequired();
            builder.Property(e => e.GameId).IsRequired();
            builder.Property(e => e.BookDate).IsRequired();
            builder.Property(e => e.ReturnDate).IsRequired();
            builder.ToTable("Reservations");
        }
    }
}
