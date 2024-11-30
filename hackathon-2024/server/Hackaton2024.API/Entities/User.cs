using System.Data;
using System.Net;

namespace Hackaton2024.API.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<UserActivity> UserActivities { get; set; }
    }
}
