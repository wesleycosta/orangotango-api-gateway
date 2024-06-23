using Ocelot.Middleware;
using Orangotango.Api;
using Orangotango.Api.Gateway;

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
