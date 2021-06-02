using SchoolManagar.Contracts;
using SchoolManagar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagar.Repository
{
    public class LevelRepository : ILevelRepository
    {
        private readonly ApplicationDbContext _db;
        public LevelRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Level entity)
        {
            var Level = _db.Levels.Add(entity);
            return Save();
        }

        public bool Delete(Level entity)
        {
            _db.Levels.Remove(entity);
            return Save();
        }

        public ICollection<Level> FindAll()
        {
            var Level = _db.Levels.ToList();
            return Level;
        }

        public Level FindById(int id)
        {
            var Level = _db.Levels.Find(id);
            return Level;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Level entity)
        {
            _db.Levels.Update(entity);
            return Save();
        }
    }
}
