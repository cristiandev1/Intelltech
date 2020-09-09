using Intelltech.Data;
using Intelltech.Interfaces;
using Intelltech.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Intelltech.Repositories
{
    public class GeometricShapesRepository : IGeometricShapesRepository
    {
        private readonly DataContext _db;
        
        public GeometricShapesRepository(DataContext db) 
        {
            _db = db;
        }
        public async Task<GeometricShapes> create(GeometricShapes geometric)
        {

            var issetDirectory = await _db.Directories.FirstOrDefaultAsync(x => x.Id == geometric.DirectoriesId);
            if (issetDirectory != null)
            {
                _db.GeometricShapes.Add(geometric);
                _db.SaveChanges();
                return geometric;
            }else { return null; }

        }

        public async Task<List<GeometricShapes>> getAll() => await _db.GeometricShapes.ToListAsync();

    }
}
