using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CTM.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CTM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IFizzBuzzService _service;
        public  ValuesController(IFizzBuzzService service)
        {
            _service = service;
        }

        // GET api/values/5
        [HttpGet("{n}")]
        public List<string> Get(int n)
        {
            if (n <= 0)
            {
                return new List<string> { "Value cannot be less than 0 or 0" };
            }
            else if (n > 100)
            {
                return new List<string> { "Value cannot be more than 100" };
            }
            else
            {
                return _service.FizzBuzz(n);
            }
        }

       
    }
}
