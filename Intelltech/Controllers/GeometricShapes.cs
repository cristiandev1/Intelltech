using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intelltech.Controllers
{
    [ApiController]
    [Route("")]
    public class GeometricShapes : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public void create() { }

        [HttpGet]
        [Route("")]
        public void getAll() { }
    }
}
