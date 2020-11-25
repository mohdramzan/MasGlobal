//using FluentValidation.Internal;
//using MediatR.Extensions.FluentValidation.AspNetCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//namespace Relyon.SCS.GST.IOC.Configurations
//{
//    public class FluentValidationConfig : IConfigurable
//    {
//        public void ConfigureService(IServiceCollection services, IConfiguration configuration)
//        {
//            services.AddFluentValidation(new[]
//            {
//                typeof(Relyon.SCS.GST.Application.MonthYear.Commands.CreateMonthYearCommandValidator).Assembly
//            });
//        }
//    }
//}
