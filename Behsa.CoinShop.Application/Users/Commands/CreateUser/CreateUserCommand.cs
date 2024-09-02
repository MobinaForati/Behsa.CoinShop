namespace Behsa.CoinShop.Application.Users.Commands.CreateUser;

public record CreateUserCommand : IRequest<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}