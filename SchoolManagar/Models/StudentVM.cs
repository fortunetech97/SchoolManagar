using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagar.Models
{
    public class StudentVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        [Required]
        public string RollId { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Gender { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string DateOfBirth { get; set; }
        public string Photo { get; set; }

       
        public DepartmentVM DepartmentName { get; set; }
        public int DepartmentId { get; set; }

        
        public LevelVM LevelName { get; set; }
        public int LevelId { get; set; }

        public IEnumerable<SelectListItem> Department { get; set; }
        public IEnumerable<SelectListItem> Level { get; set; }

    }
}
