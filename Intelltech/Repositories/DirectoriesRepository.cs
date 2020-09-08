using Intelltech.Data;
using Intelltech.Interfaces;
using Intelltech.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intelltech.Repositories
{
    public class DirectoriesRepository : IDirectoriesRepository
    {
        private readonly DataContext _db;

        public DirectoriesRepository(DataContext db) {
            _db = db;
        }
        
        public async Task<Directories> create(Directories directory)
        {
            try
            {
                _db.Directories.Add(directory);
                _db.SaveChanges();
                return directory;
            }
            catch (Exception ex) {
                return null;
            }
        }

        public async Task<List<Directories>> getAll()
        {
            try
            {
                List<Directories> result = await _db.Directories.ToListAsync();
                return result;
            }
            catch (Exception ex) {
                return null;
            }
        }
    }
}
