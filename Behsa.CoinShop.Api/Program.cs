using Behsa.CoinShop.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
{
    builder.Services.RegisterApplicationServices()
                    .RegisterInfrastructureServices(builder.Configuration)
                    .RegisterPresentationServices();
}
var app = builder.Build();
{
    app.UseRouting();
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}