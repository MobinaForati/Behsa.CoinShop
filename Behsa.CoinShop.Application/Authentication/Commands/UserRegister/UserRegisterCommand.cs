using Behsa.CoinShop.Domain.Enums;

namespace Behsa.CoinShop.Application.Authentication.Commands.UserRegister;

public record UserRegisterCommand(
     string FirstName,
     string LastName,
     string Email,
     string UserName,
     string Password,
     Gender Gender
) : IRequest<int>;