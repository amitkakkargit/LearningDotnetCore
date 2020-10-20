using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddAddTransientWithDelegate.Common;
using AddAddTransientWithDelegate.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AddAddTransientWithDelegate.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SilverUserController : ControllerBase
    {
         private readonly IDiscount _discount;
        public SilverUserController(DiscountServiceResolver discountServiceResolver)
        {
            _discount = discountServiceResolver("SILVER");
        }

        [HttpGet]
        public string Get()
        {
            return _discount.GetDiscount();   
        }
    }
}
