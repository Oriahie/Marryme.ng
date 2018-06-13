using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Infrastructure.Data
{
    public class MarryRepository<T> : IRepository<T> where T : BaseModel
    {
        protected readonly MarryDBContext _context;
        public MarryRepository()
        {
            _context = new MarryDBContext();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            Save();
        }

        public IEnumerable<T> Findby(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetSingle(int id)
        {
            return _context.Set<T>().FirstOrDefault(c=> c.ID == id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
