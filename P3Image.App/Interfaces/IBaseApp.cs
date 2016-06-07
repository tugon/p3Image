using System.Collections.Generic;

namespace P3Image.App.Interfaces
{
    public interface IBaseApp<T> where T : class
    {
        T Add(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        T Update(T entity);
        T Remove(T entity);
        void Dispose();
    }
}