using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagar.Data
{
    public class User : IdentityUser
    {
        public string RollId { get; set; }
        public string  Firstname { get; set; }
        public string  Lastname { get; set; }
        public string  Gender { get; set; }
        public string  Address { get; set; }
        public string  DateOfBirth { get; set; }
        public string  Photo { get; set; }

        [ForeignKey("DepartmentId")]
        public Department DepartmentName { get; set; }
        public int DepartmentId { get; set; }

        [ForeignKey("LevelId")]
        public Level LevelName { get; set; }
        public int LevelId { get; set; }


    }
}
