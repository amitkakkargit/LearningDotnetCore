using Microsoft.AspNetCore.Mvc;
using daysix.Models;

namespace daysix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MembershipController : ControllerBase
    {
        IDataRepository temp;
        public MembershipController(IDataRepository repository)
        {
            temp = repository;
        }
        [HttpPost]
        public void Post([FromBody] Membership value)
        {
            temp.Add(value);
        }
        [HttpPost("login")]
        public ActionResult PostData([FromBody] Membership value)
        {
            var ctr = temp.LoginValidate(value.username, value.password);
            return Ok(ctr);
        }
    }
}
