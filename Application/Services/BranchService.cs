using Domain.Models;
using Application.DataContext;
using Application.Interfaces;
using Dapper;

namespace Application.Services;

public class BranchService:IBranchService
{

    private readonly DataContext.ConText connection;

    public BranchService()
    {
        connection = new ConText();
    }


    public bool CreateBranch(Branch branch)
    {
        var sql = "insert into Branch(branch_name,department_id) values(@BranchName,@DepartmentId);";
        int res = connection.Connection().Execute(sql, branch);
        return res != 0;
    }

    public List<Branch> getBranches()
    {
        var sql = "select * from Branch;";
        var Branchs = connection.Connection().Query<Branch>(sql).ToList();
        return Branchs;
    }

    public bool UpdateBranch(Branch branch)
    {
        var sql = "update Branch set branch_name=@BranchName,department_id=@DepartmentId where branch_id = @id;";
        int res = connection.Connection().Execute(sql, branch);
        return res != 0;
    }

    public bool DleteBranch(int id)
    {
        var sql = "delete from branch where branch_id=@ID;";
        int res = connection.Connection().Execute(sql, new { ID = id });
        return res != 0;
    }
}