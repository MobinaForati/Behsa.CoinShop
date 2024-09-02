using Behsa.CoinShop.Application.Authentication.Commands.UserRegister;
using Behsa.CoinShop.Application.Authentication.Queries.Login;
using CleanArchitecture.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Behsa.CoinShop.Api.Controllers;

public class AuthenticationController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<int>> Register([FromBody] UserRegisterCommand userRegisterCommand,
        CancellationToken cancellationToken = default)
       => await Mediator.Send(userRegisterCommand, cancellationToken);

    [HttpPost]
    public async Task<ActionResult<UserDto>> Login([FromBody] LoginQuery loginQuery,
        CancellationToken cancellationToken = default)
       => await Mediator.Send(loginQuery, cancellationToken);
}
