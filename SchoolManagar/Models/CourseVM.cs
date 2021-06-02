using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagar.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagar.Models
{
    public class CourseVM
    {
        public int CourseId { get; set; }
        [Required]
        public string CourseCode { get; set; }
        [Required]
        public string CourseTitle { get; set; }
        
        public Level LevelName { get; set; }
        public int LevelId { get; set; }

        public IEnumerable<SelectListItem> Level { get; set; }
    }
}
