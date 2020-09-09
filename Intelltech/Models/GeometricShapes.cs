using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intelltech.Models
{
    public class GeometricShapes
    {
        public Guid Id { get; set; }

        public Directories Directories { get; set; }
        
        public Guid DirectoriesId { get; set; }

        public string Name { get; set; }

        public GeometricShapesType Type { get; set; }

        public string Color { get; set; }

        public int Pixels { get; set; }
    }
}
