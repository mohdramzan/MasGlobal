using Masglobal_Application.CQRS.Query;
using Masglobal_Infrastructure;
using Masglobal_Infrastructure.Interface.Read;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Masglobal_IOC.Configurations
{
    public class EmployeeConfig : IConfigurable
    {
      

        public void ConfigureService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IEmployeeReadRepository, EmployeeRepository>();
            services.AddMediatR(typeof(EmployeeQuery.Handler).Assembly);
        }


    }
}
