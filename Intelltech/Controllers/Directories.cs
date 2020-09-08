using Intelltech.Interfaces;
using Intelltech.Models;
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
        private readonly IDirectoriesRepository _repository;

        public Directories(IDirectoriesRepository repo) {
            _repository = repo;
        }

        [HttpPost]
        [Route("")]
        public async Task<Models.Directories> create(
            [FromBody] Models.Directories data) => await _repository.create(data);

        [HttpGet]
        [Route("")]
        public async Task<List<Models.Directories>> getAll() => await _repository.getAll();

    }
}
