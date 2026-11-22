using Assignment._21.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment._21.Configurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(s=>s.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.ToTable(x => 
            {
                x.HasCheckConstraint("ck_CapacityConstraint", "Capacity Between 1 And 25");
                x.HasCheckConstraint("ck_StartEndDateConstraint", "EndDate > StartDate");
            });
            builder.HasOne(s => s.Trainer)
                .WithMany(T=>T.Sessions)
                .HasForeignKey(s=>s.TrainerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
