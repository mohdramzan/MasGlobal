using Masglobal_Infrastructure.Dto_s;
using Masglobal_Infrastructure.Interface.Read;
using Masglobal_Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Masglobal_Infrastructure
{
    public class EmployeeRepository : IEmployeeReadRepository
    {
         DBContext dbContext = new DBContext();
        public async Task<IEnumerable<Employee>> GetALL()
        {
            try
            {
               return await dbContext.GetEmployee();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
