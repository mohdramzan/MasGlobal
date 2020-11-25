using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Masglobal_Infrastructure.Interface
{
    public interface IReadRepository<T> where T : class 
    {
        Task<IEnumerable<T>> GetALL();
       

    }
}
