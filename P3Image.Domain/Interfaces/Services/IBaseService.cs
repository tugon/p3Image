using System.Collections.Generic;

namespace P3Image.Domain.Interfaces.Services
{
    public interface IBaseService<T> where T : class
    {
        T Add(T entity);
        T GetById(int id);
        IList<T> GetAll();
        T Update(T entity);
        T Remove(T entity);
        void Dispose();
    }
}