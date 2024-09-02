
using FluentValidation;

namespace Behsa.CoinShop.Application.Users.Commands.CreateUser;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(u => u.FirstName)
               .NotEmpty().WithMessage("this field is required")
               .MaximumLength(50).WithMessage("first name must be less than 50");

        RuleFor(u => u.LastName)
               .NotEmpty().WithMessage("this field is required")
               .MaximumLength(50).WithMessage("last name must be less than 50");
    }

    private object RuleFor(Func<object, object> value)
    {
        throw new NotImplementedException();
    }
}