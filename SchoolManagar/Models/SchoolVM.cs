using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagar.Models
{
    public class SchoolVM
    {
        public int SchoolId { get; set; }
        [Required]
        public string SchoolName { get; set; }
    }
}
