using Microsoft.EntityFrameworkCore;
using OrganistaProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OrganistaProject.Repository.Concrete.EntityFramework
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext _db;

        public GenericRepository(DbContext db)
        {
            _db = db;
        }

        public void Add(T entity)
        {
            _db.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            _db.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().Where(predicate);
        }

        public T Get(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return _db.Set<T>();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
