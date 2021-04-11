using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
      

        private readonly ILogger<PersonsController> _logger;

        public PersonsController(ILogger<PersonsController> logger)
        {
            _logger = logger;
        }

       
    }
}
