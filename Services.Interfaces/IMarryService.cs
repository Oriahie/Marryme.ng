using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Services.Interfaces
{
    public interface IMarryService<T>
    {
        IEnumerable<T> Findby(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAll();
        T GetSingle(int id);
        void Save();
        void Add(T entity);
    }
}
