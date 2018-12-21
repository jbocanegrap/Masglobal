using Masglobal.BLL;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace Masglobal.Controllers
{
    public class EmployeeApiController : ApiController
    {
        private readonly EmployeeBll _employeeBll;
        public EmployeeApiController()
        {
            _employeeBll = new EmployeeBll();
        }

        public async Task<IHttpActionResult> Get()
        {
            var result = await _employeeBll.GetEmployee();

            if (result == null)
            {
                return InternalServerError();
            }

            return Ok(result);

        }
        public async Task<IHttpActionResult> Get(int id)
        {
            var result = await _employeeBll.GetEmployee(id);

            if (result == null)
            {
                return InternalServerError();
            }

            return Ok(result);

        }

        
    }
}
