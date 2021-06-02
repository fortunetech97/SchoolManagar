using SchoolManagar.Contracts;
using SchoolManagar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagar.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _db;
        public DepartmentRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Department entity)
        {
           var department = _db.Departments.Add(entity);
            return Save();
        }

        public bool Delete(Department entity)
        {
            _db.Departments.Remove(entity);
            return Save();
        }

        public ICollection<Department> FindAll()
        {
            var department = _db.Departments.ToList();
            return department;
        }

        public Department FindById(int id)
        {
            var department = _db.Departments.Find(id);
            return department;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Department entity)
        {
            _db.Departments.Update(entity);
            return Save();
        }
    }
}
