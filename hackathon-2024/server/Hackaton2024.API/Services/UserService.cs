using AutoMapper;
using Hackaton2024.API.Entities;
using Hackaton2024.API.Exceptions;
using Hackaton2024.API.Models.DTOs;
using Hackaton2024.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hackaton2024.API.Services
{
    public class UserService : IUserService
    {

        private readonly HackatonDbContext _dbContext;
        private readonly IUserContextService _userContextService;
        private readonly IMapper _mapper;

        public UserService(HackatonDbContext dbContext, IUserContextService userContextService, IMapper mapper)
        {
            _dbContext = dbContext;
            _userContextService = userContextService;
            _mapper = mapper;
        }

        public async Task<UserDTO> GetUser(int userId)
        {
            var activities = await _dbContext.UserActivities
                .Include(ua => ua.Activity) 
                .Where(ua => ua.UserId == userId) 
                .Select(ua => ua.Activity) 
                .ToListAsync();

            var activitiesDtos = new List<ActivityDTO>();

            foreach (var activity in activities)
            {
                activitiesDtos.Add(new ActivityDTO() { Name = activity.Name, Stage = activity.Stage });
            }

            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == userId);

            if (user is null)
            {
                throw new NotFoundException("User not found");
            }

            var userDto = new UserDTO()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Points = user.Points,
                Activities = activitiesDtos
            };
            

            return userDto;
        }
    }
}
