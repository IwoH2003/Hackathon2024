using Hackaton2024.API.Models.DTOs;

namespace Hackaton2024.API.Services.Interfaces;

public interface IAccountService
{
    Task RegisterUser(RegisterUserDTO dto);
    Task<string> GenerateJwt(LoginUserDTO dto);
}
