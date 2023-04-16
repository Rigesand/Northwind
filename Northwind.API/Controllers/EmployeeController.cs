using Microsoft.AspNetCore.Mvc;
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
    }
}
