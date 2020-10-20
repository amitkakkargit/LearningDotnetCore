using FluentModelValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace dayfour.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpPost]
        public ActionResult PostEmployee([FromBody] Employee customer)
        {
            return Ok(customer);
        }
    }
}