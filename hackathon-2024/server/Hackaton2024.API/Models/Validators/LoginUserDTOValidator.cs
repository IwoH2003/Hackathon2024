using FluentValidation;
using Hackaton2024.API.Entities;
using Hackaton2024.API.Models.DTOs;

namespace Hackaton2024.API.Models.Validators;

public class LoginUserDTOValidator : AbstractValidator<LoginUserDTO>
{
    public LoginUserDTOValidator(HackatonDbContext dbContext)
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress();

        RuleFor(x => x.Password)
            .NotEmpty()
            .MinimumLength(8);
    }
}
