using System.Security.Claims;

namespace Hackaton2024.API.Services.Interfaces
{
    public interface IUserContextService
    {
        ClaimsPrincipal User { get; }
        int? GetUserId { get; }
    }
}
