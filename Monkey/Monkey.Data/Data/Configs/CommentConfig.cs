using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Data.Data.Configs
{
    public class CommentConfig : IEntityTypeConfiguration<Entities.Comment>
    {
        public void Configure(EntityTypeBuilder<Entities.Comment> builder)
        {
            builder.HasKey(e => e.CommentId);
            builder.Property(e => e.User).IsRequired();
            builder.Property(e => e.Game).IsRequired();
            builder.Property(e => e.Hour).IsRequired();
            builder.Property(e => e.Text).IsRequired();
            builder.ToTable("Comments");
        }
    }
}
