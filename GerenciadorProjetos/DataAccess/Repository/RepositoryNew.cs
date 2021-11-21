using Business.Interfaces.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RepositoryNew<TEntity> : IRepositoryNew<TEntity> where TEntity : class, new()
    {
        protected readonly DbContext Db;
        internal DbSet<TEntity> DbSet;

        public RepositoryNew(DbContext db)
        {
            Db = db;
            this.DbSet = Db.Set<TEntity>();
        }

        public async Task<TEntity> ObterPorIdAsync(int id) => await DbSet.FindAsync(id);

        public async Task<TEntity> ObterPorFiltroAsync(Expression<Func<TEntity, bool>> filter = null, string includeProperties = null, bool isTracking = false)
        {
            IQueryable<TEntity> query = DbSet;
            if (filter != null) query = query.Where(filter);


            if (includeProperties != null)
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries))
                    query = query.Include(includeProperty);

            if (!isTracking) query = query.AsNoTracking();

            return await query.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> ObterTodosAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
           string includeProperties = null, bool isTracking = false)
        {
            IQueryable<TEntity> query = DbSet;
            if (filter != null) query = query.Where(filter);

            if (includeProperties != null)
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries))
                    query = query.Include(includeProperty);

            if (orderBy != null)
                return orderBy(query);

            if (!isTracking) query = query.AsNoTracking();
            return await query.ToListAsync();
        }

        public virtual async Task RemoverAsync(TEntity entity)
        {
            Db.Remove(entity);
            await SalvarAsync();
        }

        public async Task AdicionarAsync(TEntity entity)
        {
            await DbSet.AddAsync(entity);
            await SalvarAsync();
        }
        public async Task AtualizarAsync(TEntity entity)
        {
            DbSet.Update(entity);
            await SalvarAsync();
        }

        public async Task<int> SalvarAsync() => await Db.SaveChangesAsync();


        /** MEÓDO NORMAIS  */
        public  TEntity  ObterPorId(int id) => DbSet.Find(id);

        public  TEntity ObterPorFiltro(Expression<Func<TEntity, bool>> filter = null, string includeProperties = null, bool isTracking = false)
        {
            IQueryable<TEntity> query = DbSet;
            if (filter != null) query = query.Where(filter);


            if (includeProperties != null)
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries))
                    query = query.Include(includeProperty);

            if (!isTracking) query = query.AsNoTracking();

            return query.FirstOrDefault();
        }

        public IEnumerable<TEntity> ObterTodos(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
           string includeProperties = null, bool isTracking = false)
        {
            IQueryable<TEntity> query = DbSet;
            if (filter != null) query = query.Where(filter);

            if (includeProperties != null)
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries))
                    query = query.Include(includeProperty);

            if (orderBy != null)
                return orderBy(query);

            if (!isTracking) query = query.AsNoTracking();
            return  query.ToList();
        }

        public bool Remover(TEntity entity)
        {
            Db.Remove(entity);
            var result =  Salvar();
            return result > 0 ? true : false;
        }

        public bool Adicionar(TEntity entity)
        {
            DbSet.AddAsync(entity);
            var result = Salvar();
            return result > 0 ? true : false;
        }
        public bool Atualizar(TEntity entity)
        {
            DbSet.Update(entity);
            var result = Salvar();
            return result > 0 ? true : false;
        }

        public int Salvar() => Db.SaveChanges();

        public void Dispose() => Db?.Dispose();
    }
}
