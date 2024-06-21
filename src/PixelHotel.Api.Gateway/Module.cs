using Ocelot.DependencyInjection;
using PixelHotel.Infra.Abstractions;

namespace PixelHotel.Api.Gateway
{
    public class Module : IModuleRegiterWithConfiguration
    {
        public IServiceCollection RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddOcelot(configuration);

            return services;
        }
    }
}
