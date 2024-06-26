using Ocelot.Middleware;
using Orangotango.Api;
using Orangotango.Api.Gateway;

var app = new WebAppBuilder()
    .BuildDefault(args)
    .WithDefaultServices()
    .WithCustomConfiguration((config, env) =>
    {
        config
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
            .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"ocelot.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables();
    })
    .WithServicesFromAssemblies(AssemblyRegistry.GetAssemblies())
    .WithDefaultAppConfig(app =>
    {
        app.UseCors("AllowAny");
        app.UseOcelot().Wait();
    })
    .Create();

app.Run();
