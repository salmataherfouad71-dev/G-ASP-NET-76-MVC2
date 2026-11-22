using Assignment._21.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment._21.Configurations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(p=>p.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.ToTable(x =>
            {
                x.HasCheckConstraint("ck_DurationDaysConstraint", "DurationDays Between 1 And 365");
            });
        }
    }
}
