using Hackaton2024.API.Entities;

namespace Hackaton2024.API.Models.DTOs
{
    public class UserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Points { get; set; }
        public List<ActivityDTO> Activities { get; set; }
    }
}
