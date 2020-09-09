using Intelltech.Interfaces;
using Intelltech.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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
        private readonly ErrorDetails _error;


        public GeometricShapes(IGeometricShapesRepository repo, ErrorDetails erro) {
            _error = erro;
            _repositoryGeometrics = repo;
        }

        [HttpPost]
        [Route("")]
        public async Task<dynamic> create(
            [FromBody]Models.GeometricShapes data) 
        {
            Models.GeometricShapes result = await _repositoryGeometrics.create(data);
            if (result == null)
            {
                _error.Message = "Diretório não encontrado";
                _error.StatusCode = 400;
                return _error;
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
