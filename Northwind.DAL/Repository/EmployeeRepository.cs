using Dapper;
using Microsoft.Extensions.Configuration;
using Northwind.DAL.Entities;
using Npgsql;

namespace Northwind.DAL.Repository;

public class EmployeeRepository: IEmployeeRepository
{
    private readonly IConfiguration _configuration;


    public EmployeeRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<IEnumerable<Employee>> GetAllAsync()
    {
        var query = "SELECT *FROM Employees";
        using (var connection=new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.QueryAsync<Employee>(query);
            return result;
        }
    }
}