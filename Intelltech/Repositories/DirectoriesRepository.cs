using Intelltech.Interfaces;
using Intelltech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intelltech.Repositories
{
    public class DirectoriesRepository : IDirectoriesRepository
    {
        public Task<Directories> create(Directories objDirectory)
        {
            throw new NotImplementedException();
        }

        public Task<List<Directories>> getAll()
        {
            throw new NotImplementedException();
        }
    }
}
