using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Data_Classes;

namespace TestApp.Context
{
    public class UserStoreDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }


        public UserStoreDbContext(DbContextOptions<UserStoreDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(builder =>
            {
                builder.HasDiscriminator<Roles>(x => x.Role)
                       .HasValue<User>(Roles.User)
                       .HasValue<Logistian>(Roles.Logistian)
                       .HasValue<Driver>(Roles.Driver);
            });

            modelBuilder.Entity<UserProfile>(builder =>
            {
                builder.HasDiscriminator<Roles>(x => x.RoleProfile)
                       .HasValue<UserProfile>(Roles.User)
                       .HasValue<LogistianProfile>(Roles.Logistian)
                       .HasValue<DriverProfile>(Roles.Driver);
            });

            modelBuilder.Entity<LogistianProfile>().Property(g => g.IsAvailableForHire).HasColumnName("IsAvailableForHire");
            modelBuilder.Entity<DriverProfile>().Property(g => g.IsAvailableForHire).HasColumnName("IsAvailableForHire");


        }
    }
}
