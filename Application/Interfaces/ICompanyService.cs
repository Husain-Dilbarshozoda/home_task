using Domain.Models;

namespace Application.Interfaces;

public interface ICompanyService
{
    bool CreateCompany(Company company);
    List<Company> getCompanies();
    bool UpdateCompany(Company company);
    bool DleteCompany(int id);
}