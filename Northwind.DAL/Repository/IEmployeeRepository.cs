using Northwind.DAL.Entities;

namespace Northwind.DAL.Repository;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetAllAsync();
    Task<IEnumerable<Employee>> GetByCity(string city);
    Task<IEnumerable<int>> AddAsync(Employee employee);
}