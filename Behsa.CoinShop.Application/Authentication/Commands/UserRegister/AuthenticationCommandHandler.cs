using Behsa.CoinShop.Application.Common;
using Behsa.CoinShop.Domain.Entities;

namespace Behsa.CoinShop.Application.Authentication.Commands.UserRegister;

public class AuthenticationCommandHandler(IApplicationUnitOfWork unitOfWork)
    : IRequestHandler<UserRegisterCommand, int>
{
    private readonly IApplicationUnitOfWork _uow = unitOfWork;

    public async Task<int> Handle(UserRegisterCommand request, CancellationToken cancellationToken = default)
    {
        var model = new User
        {
            Email = request.Email,
            Password = request.Password,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Gender = request.Gender,
            UserName = request.UserName
        };
        _uow.Users.Add(model);
        await _uow.SaveChangesAsync(cancellationToken);
        return model.Id;
    }
}