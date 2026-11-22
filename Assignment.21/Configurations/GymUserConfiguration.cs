using Assignment._21.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment._21.Configurations
{
    public class GymUserConfiguration<TUser> : IEntityTypeConfiguration<TUser> where TUser : GymUser
    {
        public void Configure(EntityTypeBuilder<TUser> builder)
        {
            builder.Property(u=>u.Name).HasColumnType("varchar(50)");
            builder.Property(u => u.Email).HasColumnType("varchar(100)");
            builder.Property(u => u.Phone).HasColumnType("varchar(11)");
            builder.ComplexProperty(u=>u.Address);
            builder.HasIndex(u=>u.Email).IsUnique();
            builder.HasIndex(u=>u.Phone).IsUnique();
            builder.ToTable(x=>
            {
                x.HasCheckConstraint("ck_EmailConstraint", "Email like '_%@_%._%' ");
                x.HasCheckConstraint("ck_PhoneConstraint", "LEN(Phone)=11 And (Phone Like '011%' or Phone Like '010%' or Phone Like '015%' or Phone Like '012%') ");
            });
        }
    }
}
