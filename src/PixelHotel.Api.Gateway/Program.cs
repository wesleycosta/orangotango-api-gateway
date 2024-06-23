using Ocelot.Middleware;
using Orangotango.Api.Gateway;
using PixelHotel.Api;

var app = new WebAppBuilder()
    .BuildDefault(args)
    .WithDefaultServices()
    .WithCustomConfiguration(config => config.AddJsonFile("ocelot.json"))
    .WithServicesFromAssemblies(AssemblyRegistry.GetAssemblies())
    .WithDefaultAppConfig(app =>
    {
        app.UseCors("AllowAny");
        app.UseOcelot().Wait();
    })
    .Create();

app.Run();
