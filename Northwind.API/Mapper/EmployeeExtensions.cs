using Northwind.API.Controllers.Dto;
using Northwind.DAL.Entities;

namespace Northwind.API.Mapper
{
    public static class EmployeeExtensions
    {
        public static Employee ToEmployee(this NewEmployee newEmployee)
        {
            return new Employee()
            {
                Employee_ID = newEmployee.Id,
                Last_Name = newEmployee.Last_Name,
                First_Name = newEmployee.First_Name,
                City = newEmployee.City,
            };
        }
    }
}
