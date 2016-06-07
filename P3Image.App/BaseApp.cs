using System.Collections.Generic;
using P3Image.App.Interfaces;
using P3Image.Domain.Interfaces.Services;

namespace P3Image.App
{
    public class BaseApp<T> : IBaseApp<T> where T : class
    {
        private readonly IBaseService<T> _service;

        public BaseApp(IBaseService<T> service)
        {
            _service = service;
        }

        public T Add(T entity)
        {
            return _service.Add(entity);
        }

        public T GetById(int id)
        {
            return _service.GetById(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _service.GetAll();
        }

        public T Update(T entity)
        {
            return _service.Update(entity);
        }

        public T Remove(T entity)
        {
            return _service.Remove(entity);
        }

        public void Dispose()
        {
            _service.Dispose();
        }
    }
}