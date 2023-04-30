using Dapper;
using Microsoft.Extensions.Configuration;
using Northwind.DAL.Entities;
using Npgsql;

namespace Northwind.DAL.Repository;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly IConfiguration _configuration;


    public EmployeeRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<IEnumerable<Employee>> GetAllAsync()
    {
        var query = "SELECT *FROM Employees";
        using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.QueryAsync<Employee>(query);
            return result;
        }
    }

    public async Task<IEnumerable<Employee>> GetByCity(string city)
    {
        var query = $"""
              SELECT *FROM Employees
              WHERE lower(City) like lower('{city}')
              """;
        using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.QueryAsync<Employee>(query);
            return result;
        }
    }

    public async Task<IEnumerable<int>> AddAsync(Employee employee)
    {
        var query = $@"INSERT INTO Employees
            (employee_id,last_name, first_name, city)
            values(
            @{nameof(employee.Employee_ID)},
            @{nameof(employee.Last_Name)},
            @{nameof(employee.First_Name)},
            @{nameof(employee.City)})
            returning employee_id
            ";
        using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            return await connection.QueryAsync<int>(query,employee);
        }
    }
}