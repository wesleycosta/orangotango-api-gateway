using Ocelot.DependencyInjection;
using Orangotango.Infra.Abstractions;

namespace Orangotango.Api.Gateway
{
    public class Module : IModuleRegiterWithConfiguration
    {
        public IServiceCollection RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddOcelot(configuration);
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAny", builder => builder.AllowAnyOrigin()
                       .AllowAnyHeader()
                       .AllowAnyMethod());
            });

            return services;
        }
    }
}
