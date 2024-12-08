using Domain.Models;
using Application.DataContext;
using Application.Interfaces;
using Dapper;

namespace Application.Services;

public class DepartmantService:IDepartmantService
{
    private readonly DataContext.ConText connection;

    public DepartmantService()
    {
        connection = new ConText();
    }


    public bool CreateDepartmant(Departmant departmant)
    {
        var sql = "insert into Department(department_name,company_id) values(@DepartmentName,@CompanyId);";
        int res = connection.Connection().Execute(sql, departmant);
        return res != 0;
    }

    public List<Departmant> getDepartmants()
    {
        var sql = "select * from Department;";
        var res = connection.Connection().Query<Departmant>(sql).ToList();
        return res;
    }

    public bool UpdateDepartmant(Departmant departmant)
    {
        var sql = "update Department set department_name=@DepartmentName,company_id=@CompanyId where department_id=@DepartmentId;";
        int res = connection.Connection().Execute(sql, departmant);
        return res != 0;    
    }

    public bool DleteDepartmant(int id)
    {
        var sql = "delete from Department where department_id = @Id;";
        int res = connection.Connection().Execute(sql, new { Id = id });
        return res != 0;    
    }
}