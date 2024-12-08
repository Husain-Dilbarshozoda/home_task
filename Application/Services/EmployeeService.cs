using Domain.Models;
using Application.Interfaces;
using Application.DataContext;
using Dapper;

namespace Application.Services;

public class EmployeeService:IEmployeeService
{
    private readonly DataContext.ConText connection;

    public EmployeeService()
    {
        connection = new ConText();
    }


    public bool CreateEmployee(Employee employee)
    {
        var sql = "insert into Employee(first_name,last_name,position,branch_id,department_id) values(@FirstName,@LastName,@Position,@BranchId,@DepartmentId);";
        int res = connection.Connection().Execute(sql, employee);
        return res != 0;
    }

    public List<Employee> getEmployees()
    {
        var sql = "select * from Employee;";
        var res = connection.Connection().Query<Employee>(sql).ToList();
        return res;
    }

    public bool UpdateEmployee(Employee employee)
    {
        var sql = "update Employee set first_name=@FirstName,last_name=@LastName,position=@Position,branch_id=BranchId,department_id=@DepartmentId where employee_id=@EmployeeId;";
        int res = connection.Connection().Execute(sql, employee);
        return res != 0;  
    }

    public bool DleteEmployee(int id)
    {
        var sql = "delete from Employee where employee_id = @Id;";
        int res = connection.Connection().Execute(sql, new { Id = id });
        return res != 0;
    }
}