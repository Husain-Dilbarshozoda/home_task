using Domain.Models;

namespace Application.Interfaces;

public interface IEmployeeService
{
    bool CreateEmployee(Employee employee);
    List<Employee> getEmployees();
    bool UpdateEmployee(Employee employee);
    bool DleteEmployee(int id);
}