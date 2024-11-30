﻿using Microsoft.EntityFrameworkCore;

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

            modelBuilder.Entity<Activity>().HasData(
                new Activity { Id = 1, Name = "Running" },
                new Activity { Id = 2, Name = "Reading" },
                new Activity { Id = 3, Name = "Cooking" },
                new Activity { Id = 4, Name = "Cycling" },
                new Activity { Id = 5, Name = "Swimming" },
                new Activity { Id = 6, Name = "Painting" },
                new Activity { Id = 7, Name = "Hiking" },
                new Activity { Id = 8, Name = "Dancing" },
                new Activity { Id = 9, Name = "Gardening" },
                new Activity { Id = 10, Name = "Writing" }
            );
        }
    }
}
