using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagar.Data
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        [ForeignKey("SchoolId")]
        public School SchoolName { get; set; }
        public int SchoolId { get; set; }
    }
}
