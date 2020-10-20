using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using Repository;

namespace DapperImplementation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepo;

        public EmployeeController(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Employee>> GetByID(int id)
        {
            return await _employeeRepo.GetByID(id);
        }

        [HttpGet]
        [Route("dob/{dateOfBirth}")]
        public async Task<ActionResult<List<Employee>>> GetByID(DateTime dateOfBirth)
        {
            return await _employeeRepo.GetByDateOfBirth(dateOfBirth);
        }

        [HttpPost]
        public int PostEmployee([FromBody] Employee emp)
        {
            return _employeeRepo.AddEmployee(emp);
        }


    }
}
