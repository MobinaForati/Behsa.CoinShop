﻿namespace Behsa.CoinShop.Application.Authentication.Queries.Login;

public record LoginQuery(string Username, string Password) : IRequest<UserDto>;