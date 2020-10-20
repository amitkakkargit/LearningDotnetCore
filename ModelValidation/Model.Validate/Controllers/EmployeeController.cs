using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Model.Validate.Controllers
{
    [ApiController]
    [Route("org")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult Data(string id)
        {
            return Ok(id);
        }
    }
}