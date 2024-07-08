using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Monkey.Data.Data.Configs
{
    public class UserConfig : IEntityTypeConfiguration<Entities.ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<Entities.ApplicationUser> builder)
        {
            builder.HasMany(f => f.Favorites).WithOne(e => e.User).HasForeignKey(c => c.UserId);
            builder.HasMany(f => f.Reservations).WithOne(e => e.User).HasForeignKey(c => c.UserId);

            builder.ToTable("Users");
        }
    }
}
