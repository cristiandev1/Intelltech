using Intelltech.Interfaces;
using Intelltech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intelltech.Repositories
{
    public class GeometricShapesRepository : IGeometricShapesRepository
    {
        public Task<GeometricShapes> create(GeometricShapes objGeometric)
        {
            throw new NotImplementedException();
        }

        public Task<List<GeometricShapes>> getAll()
        {
            throw new NotImplementedException();
        }
    }
}
