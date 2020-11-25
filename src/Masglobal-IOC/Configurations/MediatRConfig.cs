using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Masglobal_IOC
{
    public class MediatRConfig : IConfigurable
    {
        public void ConfigureService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(IConfigurable));
            //Domain InMemoryBus MediatR
            //services.AddScoped<IMediatorHandler, InMemoryBus>();
        }
    }
}
