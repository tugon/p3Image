using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using P3Image.Domain.Interfaces.Repositories;
using P3Image.Infra.Data.EF.Context;

namespace P3Image.Infra.Data.Repositories
{
    public class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : class
    {
        private readonly P3ImageContext _db = new P3ImageContext();
        private readonly DbSet<T> _set;

        public BaseRepository()
        {
            _set = _db.Set<T>();
        }

        public T Add(T entity)
        {
            _set.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        public T GetById(int id)
        {
            return _set.Find(id);
        }

        public IList<T> GetAll()
        {
            return _set.ToList();
        }

        public T Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
            return entity;
        }

        public T Remove(T entity)
        {
            _db.Entry(entity).State = EntityState.Deleted;
            _set.Remove(entity);
            _db.SaveChanges();
            return entity;
        }

        public IQueryable<T> Search(Func<T, bool> func)
        {
            return _set.Where(func).AsQueryable();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}