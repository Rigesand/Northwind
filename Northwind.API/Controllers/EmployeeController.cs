using Microsoft.AspNetCore.Mvc;
using Northwind.API.Controllers.Dto;
using Northwind.API.Mapper;
using Northwind.DAL.Entities;
using Northwind.DAL.Repository;

namespace Northwind.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EmployeeController
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        [HttpGet]
        public async Task<IEnumerable<Employee>> GetByCity(string city)
        {
            return await _repository.GetByCity(city);
        }

        [HttpPost]
        public async Task<IEnumerable<int>> AddAsync(NewEmployee newEmployee)
        {
            var employee = newEmployee.ToEmployee();
            return await _repository.AddAsync(employee);
        }
    }
}
