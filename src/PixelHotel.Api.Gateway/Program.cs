using Ocelot.Middleware;
using PixelHotel.Api;
using PixelHotel.Api.Gateway;

var app = new WebAppBuilder()
    .BuildDefault(args)
    .WithDefaultServices()
    .WithCustomConfiguration(config => config.AddJsonFile("ocelot.json"))
    .WithServicesFromAssemblies(AssemblyRegistry.GetAssemblies())
    .WithDefaultAppConfig(app => app.UseOcelot().Wait())
    .Create();

app.Run();
