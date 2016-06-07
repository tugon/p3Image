using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace P3Image.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> : IDisposable where T : class
    {
        T Add(T entity);
        T GetById(int id);
        IList<T> GetAll();
        T Update(T entity);
        T Remove(T entity);
        IQueryable<T> Search(Expression<Func<T, bool>> func);
    }
}