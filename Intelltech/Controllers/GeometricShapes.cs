using Intelltech.Interfaces;
using Intelltech.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
            if (result == null)
            {
                Console.WriteLine("Diretorio nao encontrado..");
                return null;
            }
            else {
                return result;
            }

        }

        [HttpGet]
        [Route("")]
        public async Task<List<Models.GeometricShapes>> getAll() => await _repositoryGeometrics.getAll();
       
    }
}
