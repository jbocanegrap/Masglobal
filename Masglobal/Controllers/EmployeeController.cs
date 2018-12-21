using Masglobal.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace Masglobal.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeBll _employeeBll;

        public EmployeeController()
        {
            _employeeBll = new EmployeeBll();
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Employees(int? id)
        {
            var value = 0;
            int.TryParse(id.ToString(), out value);
            var result = await _employeeBll.GetEmployee(value);
            return View("ViewEmployee", result);
        }
    }
}