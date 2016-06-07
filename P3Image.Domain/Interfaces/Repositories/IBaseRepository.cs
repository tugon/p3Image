using System;
using System.Collections.Generic;
using System.Linq;

namespace P3Image.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        T Add(T entity);
        T GetById(int id);
        IList<T> GetAll();
        T Update(T entity);
        T Remove(T entity);
        IQueryable<T> Search(Func<T, bool> func);
        void Dispose();
    }
}