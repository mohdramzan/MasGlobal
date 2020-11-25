using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Masglobal_IOC
{
    public interface IConfigurable
    {
        void ConfigureService(IServiceCollection services, IConfiguration configuration);
    }
}
