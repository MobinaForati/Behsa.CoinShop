using Behsa.CoinShop.Domain.Enums;

namespace Behsa.CoinShop.Application.Users.Queries.GetUser;

public record GetUserDto(int Id, Gender Gender, string Email);
