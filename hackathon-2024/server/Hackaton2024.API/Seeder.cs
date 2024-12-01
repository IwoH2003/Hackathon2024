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
                new Activity { Name = "Bieganie", PictureUrl = "https://d.allegroimg.com/original/121b3a/f42e441b424489a8d51e7a90de7d" },
                new Activity { Name = "Rysowanie", PictureUrl = "https://i0.wp.com/wiecejnizedukacja.pl/wp-content/uploads/2016/05/art-pencils-941743_1280.jpg?resize=750%2C410&ssl=1" },
                new Activity { Name = "Gotowanie", PictureUrl = "https://i.dobrzemieszkaj.pl/i/79/10/06/r3/1920/ile-kosztuje-codzienne-gotowanie-porownujemy-koszty-gazu-i-pradu.jpg" },
                new Activity { Name = "Kolarstwo", PictureUrl = "https://contents.mediadecathlon.com/p2000771/k$a0209ed446c5b7a81c7886eca1357987/1920x0/3080pt2240/6160xcr3465/default.jpg?format=auto" },
                new Activity { Name = "Pływanie", PictureUrl = "https://www.cumbre.pl/wp-content/uploads/2015/05/facilities3.jpg" },
                new Activity { Name = "Malowanie", PictureUrl = "https://media.istockphoto.com/id/1183183791/pl/zdj%C4%99cie/utalentowana-artystka-pracuje-nad-abstrakcyjnym-malarstwem-olejnym-u%C5%BCywaj%C4%85c-p%C4%99dzla-kt%C3%B3ry.jpg?s=612x612&w=0&k=20&c=Rbbicyo65Iwx-AZypZVoIgF5QN4GOuADjNGw-9z_zcY=" },
                new Activity { Name = "Hiking", PictureUrl = "https://media.post.rvohealth.io/wp-content/uploads/2020/08/couple-hiking-mountain-climbing-1200x628-facebook-1200x628.jpg" },
                new Activity { Name = "Taniec", PictureUrl = "https://www.ebilet.pl/now/app/uploads/2024/05/shutterstock_1823945150-1280x720.jpg" },
                new Activity { Name = "Ogrodnictwo", PictureUrl = "https://agromania.pl/wp-content/uploads/2024/10/ogrodnictwo-domowe.webp" },
                new Activity { Name = "Pisanie", PictureUrl = "https://static.prsa.pl/images/e32a19a7-ba5c-4c7c-ac4a-754bd85f7f7d.jpg?format=500" },
                new Activity { Name = "Fotografia", PictureUrl = "https://www.swiatobrazu.pl/zdjecie/artykuly/538771/profesjonalny-fotograf-3.jpg" },
                new Activity { Name = "Robienie na drutach", PictureUrl = "https://feblik.pl/wp-content/uploads/Warsztaty-dziewiarskie-szydelkowania-im-unique-4-1080x720.jpeg" },
                new Activity { Name = "Yoga", PictureUrl = "https://yogaclub.com/cdn/shop/articles/young-woman-practicing-yoga-urban_1024x1024.jpg?v=1563794364" }
            };

            return activities;
        }
    }
}
