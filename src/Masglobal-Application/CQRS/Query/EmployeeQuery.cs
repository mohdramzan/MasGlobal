using Masglobal_Infrastructure.Dto_s;
using Masglobal_Infrastructure.Interface.Read;
using Masglobal_Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Masglobal_Application.CQRS.Query
{
    public class EmployeeQuery
    {
        public class Query  : IRequest<List<EmployeeDto>> { }
       
        public class Handler : IRequestHandler<Query, List<EmployeeDto>>
        {
            private readonly IEmployeeReadRepository _employeeReadRepository;
            public Handler(IEmployeeReadRepository employeeReadRepository)
            {
                _employeeReadRepository = employeeReadRepository;
            }

            public async Task<List<EmployeeDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                try
                {
                    var employees = await _employeeReadRepository.GetALL();
                    var empDtoList = new List<EmployeeDto>();

                    foreach (var employee in employees)
                    {
                        var CalculatedSalary = 0.00m;
                        if (employee.RoleName == "Contractor")
                        {
                            CalculatedSalary = 120 * employee.HourlySalary * 12;
                            empDtoList.Add( AddEmployee(employee,CalculatedSalary)); 
                        }
                        else
                        {
                            CalculatedSalary = employee.MonthlySalary * 12;
                            empDtoList.Add(AddEmployee(employee, CalculatedSalary));

                        }
                    }
                    return empDtoList;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            

          public EmployeeDto AddEmployee(Employee employee,decimal CalculatedSalary)
            {
                return new EmployeeDto()
                {
                    Id = employee.Id,
                    ContractTypeName = employee.ContractTypeName,
                    HourlySalary = employee.HourlySalary,
                    MonthlySalary = employee.MonthlySalary,
                    Name = employee.Name,
                    RoleDescription = employee.RoleDescription,
                    RoleName = employee.RoleName,
                    CalculatedSalary = CalculatedSalary
                };
            }

        }
    }
}
