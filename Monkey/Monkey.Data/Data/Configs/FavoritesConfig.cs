﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Data.Data.Configs
{
    public class FavoritesConfig : IEntityTypeConfiguration<Entities.Favorite>
    {
        public void Configure(EntityTypeBuilder<Entities.Favorite> builder)
        {
            builder.Property(e => e.UserId).IsRequired();
            builder.Property(e => e.GameId).IsRequired();
            builder.ToTable("Favorites");
        }
    }
}
