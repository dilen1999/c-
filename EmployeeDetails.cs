using System.Diagnostics;

namespace ConsoleApplication2
{
    public class EmployeeDetails : IEmployee
    {
        public int EmpId { set; get; }
        public string EmpName { get; set; }
        public string Department { get; set; }
        public decimal MonthlySalary { get; set; }
        public EmployeeDetails(int empId, string empName, string department, decimal salary)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.Department = department;
            this.MonthlySalary = salary;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"EmpId: {EmpId}, EmpName: {EmpName}, Department: {Department}");
        }
        public decimal CalculateSalary()
        {
            return MonthlySalary * 12;
        }
    }
}