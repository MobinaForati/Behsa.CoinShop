using Behsa.CoinShop.Api.Filter;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Behsa.CoinShop.Api.Controllers;

[Route("[controller]/[action]"), CatchExceptionFilter, ApiController]
public abstract class BaseController : ControllerBase
{
    private ISender? _mediator;

    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}
