using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagar.Models
{
    public class DepartmentVM
    {
        public int DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }
       
        public SchoolVM SchoolName { get; set; }
        public int SchoolId { get; set; }

        public IEnumerable<SelectListItem> School { get; set; }
    }
}
