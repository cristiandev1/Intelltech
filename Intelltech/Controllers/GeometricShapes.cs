using Intelltech.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intelltech.Controllers
{
    [ApiController]
    [Route("v1/geometrics")]
    public class GeometricShapes : ControllerBase
    {
        private readonly IGeometricShapesRepository _repositoryGeometrics;

        public GeometricShapes(IGeometricShapesRepository repo) {
            _repositoryGeometrics = repo;
        }

        [HttpPost]
        [Route("")]
        public async Task<Models.GeometricShapes> create(
            [FromBody]Models.GeometricShapes data) 
        {
            Models.GeometricShapes result = await _repositoryGeometrics.create(data);
            return result;
        }

        [HttpGet]
        [Route("")]
        public async Task<List<Models.GeometricShapes>> getAll() => await _repositoryGeometrics.getAll();
    }
}
