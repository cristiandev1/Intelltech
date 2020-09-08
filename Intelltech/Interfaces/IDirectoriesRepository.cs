using Intelltech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intelltech.Interfaces
{
    public interface IDirectoriesRepository
    {
        Task<List<Directories>> getAll();

        Task<Directories> create(Directories objDirectory);
    }
}
