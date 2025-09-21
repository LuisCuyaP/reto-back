
using Core.API;
using Core.Application;
using Core.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddApiServices();

var app = builder.Build();
app.Run();
