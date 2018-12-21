
namespace Masglobal.Models
{
    public class EmployeeDTO 
    {
       
        
        public int id { get; set; }
        public string name { get; set; }
        public string contractTypeName { get; set; }
        public int roleId { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public decimal hourlySalary { get; set; }
        public decimal monthlySalary { get; set; }
        public decimal annualSalary { get => Salary(); set => Salary(); }

        private decimal Salary()
        {
            switch (contractTypeName)
            {
                case "HourlySalaryEmployee":
                    return decimal.Round(120 * hourlySalary * 12, 2);
                case "MonthlySalaryEmployee":
                    return decimal.Round(monthlySalary * 12, 2);
                default:
                    return 0M;
            }
        }       
    }
}