using Domain.Models;

namespace Application.Interfaces;

public interface IDepartmantService
{
    bool CreateDepartmant(Departmant departmant);
    List<Departmant> getDepartmants();
    bool UpdateDepartmant(Departmant departmant);
    bool DleteDepartmant(int id);
}