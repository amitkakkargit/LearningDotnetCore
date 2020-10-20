using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using modelstateclass.Models;
namespace modelstateclass.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpPost]
        public ActionResult Post([FromBody] Customer cust)
        {
            if (ModelState.IsValid)
            {
                //insert customer
                return Ok(cust);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
