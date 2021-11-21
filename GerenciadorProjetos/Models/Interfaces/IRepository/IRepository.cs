using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Interfaces.IRepository
{
    public interface  IRepository<TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity,bool>> expression);
        IEnumerable<TEntity> Filter(Expression<Func<TEntity, bool>> expressionFilter);

        void Delete(int id);

        void Save();
    }

}
