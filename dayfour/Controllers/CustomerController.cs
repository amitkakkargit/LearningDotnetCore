using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dayfour.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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