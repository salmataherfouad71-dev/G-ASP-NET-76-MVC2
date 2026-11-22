using System.Reflection;
using Assignment._21.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment._21.Contexts
{
    public class GymDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= . ;Database= Gym_System ;Trusted_Connection= True ;TrustServerCertificate= True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Member> Members{ set; get; }
        public DbSet<Trainer> Trainers{ set; get; }
        public DbSet<Plan> Plans { set; get; }
        public DbSet<Session> Sessions { set; get; }
        public DbSet<MemberShip> MembersShips { set; get; }
    }
}
