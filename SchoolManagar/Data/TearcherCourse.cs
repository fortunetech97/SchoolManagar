using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagar.Data
{
    public class TearcherCourse
    {
        public int Id { get; set; }

        [ForeignKey("UserId")]
        public User Teacher { get; set; }
        public string UserId { get; set; }

        [ForeignKey("CourseId")]
        public Course CourseName { get; set; }
        public int CourseId { get; set; }
    }
}
