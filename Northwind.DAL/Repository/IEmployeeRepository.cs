using Northwind.DAL.Entities;

namespace Northwind.DAL.Repository;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetAllAsync();
}