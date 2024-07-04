using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Data.Data.Configs
{
    public class RatingConfig : IEntityTypeConfiguration<Entities.Rating>
    {
        public void Configure(EntityTypeBuilder<Entities.Rating> builder)
        {
            builder.HasKey(e => e.RatingId);
            builder.Property(e => e.User).IsRequired();
            builder.Property(e => e.Game).IsRequired();
            builder.Property(e => e.Rate).IsRequired();
            builder.ToTable("Ratings");
        }
    }
}
