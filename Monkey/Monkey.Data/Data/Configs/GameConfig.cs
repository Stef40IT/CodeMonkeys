using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Data.Data.Configs
{
    public class GameConfig : IEntityTypeConfiguration<Entities.Game>
    {
        public void Configure(EntityTypeBuilder<Entities.Game> builder)
        {
            builder.HasKey(e => e.GameId);
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.Description).IsRequired();
            builder.Property(e => e.Picture).IsRequired();
            builder.Property(e => e.Difficulty).IsRequired();
            builder.Property(e => e.Count).IsRequired();
            builder.HasMany(e => e.Comments).WithOne(f => f.Game).HasForeignKey(c => c.Game);
            builder.HasMany(e => e.Raitings).WithOne(f => f.Game).HasForeignKey(c => c.Rate);
            builder.Property(e => e.isBooked).IsRequired();
            builder.ToTable("Games");
        }
    }
}
