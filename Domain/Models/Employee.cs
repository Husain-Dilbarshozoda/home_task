namespace Domain.Models;

public class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public int BranchId { get; set; }
    public int DepartmentId { get; set; }
}