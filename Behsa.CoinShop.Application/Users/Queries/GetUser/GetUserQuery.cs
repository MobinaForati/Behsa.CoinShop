namespace Behsa.CoinShop.Application.Users.Queries.GetUser;

public record GetUserQuery(int Id) : IRequest<GetUserDto>;