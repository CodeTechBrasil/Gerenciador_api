using Business.Interfaces.IRepository;
using DataAccess.context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
         private ApplicationDbContext _applicationContext { get; set; }
         private DbSet<TEntity> _dbSet { get; set; }

        public Repository(ApplicationDbContext applicationContextDb)
        {
            _applicationContext = applicationContextDb;
            _dbSet = applicationContextDb.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            Save();
        }
        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity,bool>> expression)
        {
            return _dbSet.Where(expression).ToList();
        }
  
   
        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
            Save();
        }

        public void Delete(int id)
        {
            _dbSet.Remove(GetById(id));
            Save();
        }

        public void Save()
        {
           _applicationContext.SaveChanges();
        }

        public IEnumerable<TEntity> Filter(Expression<Func<TEntity, bool>> expressionFilter)
        {
            return _dbSet.Where(expressionFilter);
        }
    }
}
