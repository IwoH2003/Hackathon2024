using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Hackaton2024.API.Entities
{
    public class HackatonDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<UserActivity> UserActivities { get; set; }

        public HackatonDbContext(DbContextOptions<HackatonDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserActivity>()
                .HasKey(ua => new { ua.UserId, ua.ActivityId });

            modelBuilder.Entity<UserActivity>()
                .HasOne(ua => ua.User)
                .WithMany(u => u.UserActivities)
                .HasForeignKey(ua => ua.UserId);

            modelBuilder.Entity<UserActivity>()
                .HasOne(ua => ua.Activity)
                .WithMany(a => a.UserActivities)
                .HasForeignKey(ua => ua.ActivityId);
        }
    }
}
