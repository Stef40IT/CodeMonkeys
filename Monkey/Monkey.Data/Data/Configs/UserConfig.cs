using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Monkey.Data.Data.Configs
{
    public class UserConfig : IEntityTypeConfiguration<Entities.User>
    {
        public void Configure(EntityTypeBuilder<Entities.User> builder)
        {
            builder.HasKey(e => e.UserID);
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.Email).IsRequired();
            builder.Property(e => e.Password).IsRequired();
            builder.Property(e => e.IsAdmin).IsRequired();
            builder.HasMany(f => f.Favorites).WithOne(e => e.User).HasForeignKey(c => c.User);
            builder.HasMany(f => f.Reservations).WithOne(e => e.User).HasForeignKey(c => c.User);

            builder.ToTable("Users");
        }
    }
}
