using Hackaton2024.API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Hackaton2024.API
{
    public class Seeder
    {
        private readonly HackatonDbContext _dbContext;

        public Seeder(HackatonDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!await _dbContext.Activities.AnyAsync())
                {
                    var activities = SeedActivities();
                    await _dbContext.Activities.AddRangeAsync(activities);
                    await _dbContext.SaveChangesAsync();
                }

                SeedUser();
            }
        }

        private void SeedUser()
        {
            var user = new User()
            {
                FirstName = "Test",
                LastName = "Test",
                Email = "test@test.pl"
            };

            var running = _dbContext.Activities.FirstOrDefault(a => a.Name == "Running");
            var reading = _dbContext.Activities.FirstOrDefault(a => a.Name == "Reading");

            user.UserActivities = new List<UserActivity>
            {
                new UserActivity { Activity = running },
                new UserActivity { Activity = reading }
            };

            user.PasswordHash = "";

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        private IEnumerable<Activity> SeedActivities()
        {
            List<Activity> activities = new List<Activity>
            {
                new Activity() { Name = "Running" },
                new Activity() { Name = "Reading" },
                new Activity() { Name = "Cooking" },
                new Activity() { Name = "Cycling" },
                new Activity() { Name = "Swimming" },
                new Activity() { Name = "Painting" },
                new Activity() { Name = "Hiking" },
                new Activity() { Name = "Dancing" },
                new Activity() { Name = "Gardening" },
                new Activity() { Name = "Writing" }
            };

            return activities;
        }
    }
}
