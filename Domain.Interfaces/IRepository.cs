using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IRepository<T> where T: BaseModel
    {
        IEnumerable<T> Findby(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAll();
        T GetSingle(int id);
        void Save();
        void Add(T entity);
    }
}
