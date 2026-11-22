using Assignment._21.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment._21.Configurations
{
    public class MemberConfiguration:GymUserConfiguration<Member>,IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(m => m.CreatedAt).HasColumnName("JoinDate").HasDefaultValueSql("GETDATE()") ;
            base.Configure(builder);
        }
    }
}
