using Microsoft.EntityFrameworkCore;
using MusicApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApplication
{
    public class MusicRepository<T> : IGenericRepository<T> where T: class
    {
        private ApplicationContext _context;
        private DbSet<T> entites;
        public MusicRepository(ApplicationContext context)
        {
            _context = context;
            entites = context.Set<T>();

        }
        public IEnumerable<T> GetAll()
        {
            return entites.ToList();
        }

        public T GetById(int id)
        {
            return entites.Find(id);
        }

        
        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            entites.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                _context.SaveChanges();
            }
            catch (DbEntityValidationException) { }
        }
        public void Delete(int id)
        {
            var ent = entites.Find(id);
            entites.Remove(ent);
            _context.SaveChanges();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public int GetCountOfSongs()
        {
            return _context.Songs.Count();
        }
    }
}
