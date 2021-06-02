using SchoolManagar.Contracts;
using SchoolManagar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagar.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext _db;
        public CourseRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Course entity)
        {
            var Course = _db.Courses.Add(entity);
            return Save();
        }

        public bool Delete(Course entity)
        {
            _db.Courses.Remove(entity);
            return Save();
        }

        public ICollection<Course> FindAll()
        {
            var Course = _db.Courses.ToList();
            return Course;
        }

        public Course FindById(int id)
        {
            var Course = _db.Courses.Find(id);
            return Course;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Course entity)
        {
            _db.Courses.Update(entity);
            return Save();
        }
    }
}
