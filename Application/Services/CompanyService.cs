using Domain.Models;
using Application.DataContext;
using Application.Interfaces;
using Dapper;

namespace Application.Services;

public class CompanyService:ICompanyService
{
    private readonly DataContext.ConText connection;

    public CompanyService()
    {
        connection = new ConText();
    }

    public bool CreateCompany(Company company)
    {
        var sql = "insert into Company(company_name,company_address) values(@CompanyName,@CompanyAddress);";
        int res = connection.Connection().Execute(sql, company);
        return res != 0;
    }

    public List<Company> getCompanies()
    {
            var sql = "select * from Company;";
            var Companies = connection.Connection().Query<Company>(sql).ToList();
            return Companies;
    }

    public bool UpdateCompany(Company company)
    {
        var sql = "update Company set company_name=@CompanyName,company_address=@CompanyAddress where company_id=@CompanyId;";
        int res = connection.Connection().Execute(sql, company);
        return res != 0;
    }

    public bool DleteCompany(int id)
    {
        var sql = "delete from Company where id = @Id;";
        int res = connection.Connection().Execute(sql, new { Id = id });
        return res != 0;
    }
}