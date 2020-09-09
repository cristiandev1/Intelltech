using Intelltech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intelltech.Interfaces
{
    public interface IGeometricShapesRepository
    {
        Task<List<GeometricShapes>> getAll();

        Task<GeometricShapes> create(GeometricShapes objGeometric);
      
    }
}
