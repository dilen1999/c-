namespace ConsoleApplication2
{
    public interface IEmployee
    {
        int EmpId { set; get; }
        string EmpName { get; set; }
        string Department { get; set; }
        void DisplayEmployeeDetails();
        decimal CalculateSalary();
    }
}