﻿using Behsa.CoinShop.Api.Controllers;
using Behsa.CoinShop.Application.Users.Commands.CreateUser;
using Behsa.CoinShop.Application.Users.Queries.GetUser;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controllers;

public class UserController : BaseController
{
    [HttpGet]
    public async Task<ActionResult<GetUserDto>> GetUser([FromQuery] GetUserQuery query)
     => await Mediator.Send(query);

    [HttpPost]
    public async Task<ActionResult<int>> Create(CreateUserCommand command)
       => await Mediator.Send(command);
}
