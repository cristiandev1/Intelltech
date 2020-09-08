using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intelltech.Controllers
{   
    [ApiController]
    [Route("v1/directories")]
    public class Directories : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public void create() { 
        }

        [HttpGet]
        [Route("")]
        public void getAll() {
        }

    }
}
