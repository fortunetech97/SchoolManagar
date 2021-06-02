using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagar.Models
{
    public class LevelVM
    {
        public int LevelId { get; set; }
        [Required]
        public string LevelName { get; set; }
    }
}
