using Hackaton2024.API.Models;

namespace Hackaton2024.API.Entities
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public ICollection<UserActivity> UserActivities { get; set; }
    }
}
