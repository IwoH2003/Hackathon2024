using Hackaton2024.API.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Hackaton2024.API.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> GetUser(int userId);
        Task AddPoints(int userId, ChangeStageDTO stageDTO);
    }
}
