using FluentValidation;
using Hackaton2024.API.Entities;
using Hackaton2024.API.Models.DTOs;

namespace Hackaton2024.API.Models.Validators;

public class RegisterUserDTOValidator : AbstractValidator<RegisterUserDTO>
{
    public RegisterUserDTOValidator(HackatonDbContext dbContext)
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress();

        RuleFor(x => x.Password)
            .NotEmpty()
            .MinimumLength(8);

        RuleFor(x => x.ConfirmPassword)
            .NotEmpty()
            .Equal(comparer => comparer.Password);

        RuleFor(x => x.Email)
            .Custom((value, context) =>
            {
                bool emailInUse = dbContext.Users.Any(u => u.Email == value);

                if (emailInUse)
                {
                    context.AddFailure("Email", "Email is taken");
                }
            });

        RuleFor(x => x.FirstName)
            .NotEmpty();

        RuleFor(x => x.LastName)
            .NotEmpty();
    }
}

