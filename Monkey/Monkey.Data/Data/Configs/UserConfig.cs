using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monkey.Data.Data.Entities;

namespace Monkey.Data.Data.Configs
{
    public class UserConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasMany(f => f.Favorites).WithOne(e => e.User).HasForeignKey(c => c.UserId);
            builder.HasMany(f => f.Reservations).WithOne(e => e.User).HasForeignKey(c => c.UserId);
        }
    }
}
