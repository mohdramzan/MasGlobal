using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.SelfHost;

namespace Masglobal_Persistance
{
    public class DBContext
    {

        public async Task<List<Employee>> GetEmployee()
        {
            HttpClient client = new HttpClient();
            var listEmployees = new List<Employee>();
            HttpResponseMessage resp = await client.GetAsync("http://masglobaltestapi.azurewebsites.net/api/Employees");

            var employees = await resp.Content.ReadAsAsync<IEnumerable<Employee>>();
            
             foreach (var employee in employees)
            {

                listEmployees.Add(new Employee()
                {
                    Id = employee.Id,
                    ContractTypeName = employee.ContractTypeName,
                    HourlySalary = employee.HourlySalary,
                    MonthlySalary = employee.MonthlySalary,
                    Name = employee.Name,
                    RoleDescription = employee.RoleDescription,
                    RoleName = employee.RoleName
                });
            }

            return listEmployees;
        }
    }
}
