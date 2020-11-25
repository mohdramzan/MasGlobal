//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Relyon.SCS.GST.Data;
//using Relyon.SCS.GST.Data.EFCoreSpecific;

//namespace Relyon.SCS.GST.IOC.Configurations
//{
//    public class DbContextConfig : IConfigurable
//    {
//        public void ConfigureService(IServiceCollection services, IConfiguration configuration)
//        {
//            services.AddDbContext<phoenixgstContext>(options =>
//            {
               
//                options.UseNpgsql(ConnectionManager.ConnectionString);
//                options.EnableSensitiveDataLogging();
//            },
//          ServiceLifetime.Scoped);
//        }
//    }
//}
