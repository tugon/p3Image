using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using P3Image.Domain.Interfaces.Repositories;

namespace P3Image.Infra.Data.Repositories
{
    public class BaseRepository<T, TC> : IBaseRepository<T>
        where TC : DbContext
        where T : class
    {
        private readonly TC _db;
        private readonly DbSet<T> _set;

        public BaseRepository(TC db)
        {
            _db = db;
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

        public IQueryable<T> Search(Expression<Func<T, bool>> func)
        {
            IQueryable<T> query =_set;

            if (func != null)
            {
                query = query.Where(func);
            }

            
                return query;
        }

        public void Dispose()
        {
            if (_db != null)
                _db.Dispose();
        }
    }
}