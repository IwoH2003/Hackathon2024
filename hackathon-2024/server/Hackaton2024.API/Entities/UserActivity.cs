using Hackaton2024.API.Models;

namespace Hackaton2024.API.Entities
{
    public class UserActivity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int ActivityId { get; set; }
        public Activity Activity { get; set; }

        public ActivityStage Stage { get; set; }
    }
}
