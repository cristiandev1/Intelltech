using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intelltech.Models
{
    public class Directories
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Este campo é requerido")]
        public string Name { get; set; }
    }
}
