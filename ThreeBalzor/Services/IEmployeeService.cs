using System.Collections.Generic;
using System.Threading.Tasks;
using ThreeBalzor.Models;

namespace ThreeBalzor.Services
{
    public interface IEmployeeService
    {
        Task Add(Employee employee);
        Task<IEnumerable<Employee>> GetByDepartmentId(int departmentId);
        Task<Employee> Fired(int id);
    }
}