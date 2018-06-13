using Domain.Entities;
using Infrastructure.Data;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Service
{
    public class MarryService<T> : IMarryService<T> where T: BaseModel
    {
        private readonly MarryRepository<T> repo;
        public MarryService()
        {
            repo = new MarryRepository<T>();
        }

        public void Add(T entity)
        {
            repo.Add(entity);
        }

        public IEnumerable<T> Findby(Expression<Func<T, bool>> predicate)
        {
            return repo.Findby(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return repo.GetAll();
        }

        public T GetSingle(int id)
        {
            return repo.GetSingle(id);
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
