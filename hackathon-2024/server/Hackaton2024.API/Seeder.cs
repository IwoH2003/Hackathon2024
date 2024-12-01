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
            }
        }

        private IEnumerable<Activity> SeedActivities()
        {
            List<Activity> activities = new List<Activity>
            {
                new Activity { Name = "Bieganie", PictureUrl = "https://github.com/IwoH2003/Hackathon2024/blob/main/hackathon-2024/src/images/running.jpg" },
                new Activity { Name = "Rysowanie", PictureUrl = "https://github.com/IwoH2003/Hackathon2024/blob/main/hackathon-2024/src/images/drawing.jpg" },
                new Activity { Name = "Gotowanie", PictureUrl = "https://github.com/IwoH2003/Hackathon2024/blob/main/hackathon-2024/src/images/cooking.jpg" },
                new Activity { Name = "Kolarstwo", PictureUrl = "https://github.com/IwoH2003/Hackathon2024/blob/main/hackathon-2024/src/images/cycling.jpg" },
                new Activity { Name = "Pływanie", PictureUrl = "https://github.com/IwoH2003/Hackathon2024/blob/main/hackathon-2024/src/images/swimming.jpg" },
                new Activity { Name = "Malowanie", PictureUrl = "https://github.com/IwoH2003/Hackathon2024/blob/main/hackathon-2024/src/images/painting.jpg" },
                new Activity { Name = "Hiking", PictureUrl = "https://github.com/IwoH2003/Hackathon2024/blob/main/hackathon-2024/src/images/hiking.jpg" },
                new Activity { Name = "Taniec", PictureUrl = "https://github.com/IwoH2003/Hackathon2024/blob/main/hackathon-2024/src/images/dancing.jpg" },
                new Activity { Name = "Ogrodnictwo", PictureUrl = "https://github.com/IwoH2003/Hackathon2024/blob/main/hackathon-2024/src/images/gardening.jpg" },
                new Activity { Name = "Pisanie", PictureUrl = "https://github.com/IwoH2003/Hackathon2024/blob/main/hackathon-2024/src/images/writing.jpg" },
                new Activity { Name = "Fotografia", PictureUrl = "https://github.com/IwoH2003/Hackathon2024/blob/main/hackathon-2024/src/images/camera.jpg" },
                new Activity { Name = "Robienie na drutach", PictureUrl = "https://github.com/IwoH2003/Hackathon2024/blob/main/hackathon-2024/src/images/knitting.jpg" },
                new Activity { Name = "Yoga", PictureUrl = "https://github.com/IwoH2003/Hackathon2024/blob/main/hackathon-2024/src/images/yoga.jpg" }
            };

            return activities;
        }
    }
}
