using Masglobal.DAL;
using Masglobal.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Masglobal.BLL
{
    public class EmployeeBll
    {
        private readonly Employees _employee;

        public EmployeeBll()
        {
            _employee = new Employees();
        }
        public async Task<IEnumerable<EmployeeDTO>> GetEmployee(int id = 0)
        {
            var lstEmployees = _employee.GetAsync(id);
            return await lstEmployees;
        }

    }
}