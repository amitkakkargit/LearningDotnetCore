using FluentModelValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace dayfour.Controllers
{
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public ActionResult PostCustomer([FromBody] Customer customer)
        {            
            return Ok(customer);
        }
    }
}