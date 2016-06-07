using System;
using System.Collections.Generic;
using P3Image.Domain.Interfaces.Repositories;
using P3Image.Domain.Interfaces.Services;

namespace P3Image.Domain.Services
{
    public class BaseService<T> : IDisposable, IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _rep;

        public BaseService(IBaseRepository<T> rep)
        {
            _rep = rep;
        }

        public T Add(T entity)
        {
            return _rep.Add(entity);
        }

        public T GetById(int id)
        {
            return _rep.GetById(id);
        }

        public IList<T> GetAll()
        {
            return _rep.GetAll();
        }

        public T Update(T entity)
        {
            return _rep.Update(entity);
        }

        public T Remove(T entity)
        {
            return _rep.Remove(entity);
        }

        public void Dispose()
        {
            _rep.Dispose();
        }
    }
}