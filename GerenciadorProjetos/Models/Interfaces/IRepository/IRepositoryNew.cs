using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace Business.Interfaces.IRepository
{
    public interface IRepositoryNew<TEntity> : IDisposable where TEntity : class
    {
        Task<TEntity> ObterPorIdAsync(int id);
        Task<IEnumerable<TEntity>> ObterTodosAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = null,
            bool isTracking = false
        );

        Task<TEntity> ObterPorFiltroAsync(
            Expression<Func<TEntity, bool>> filter = null,
            string includeProperties = null,
            bool isTracking = false
        );
        Task AdicionarAsync(TEntity entity);
        Task AtualizarAsync(TEntity entity);
        Task RemoverAsync(TEntity entity);
        Task<int> SalvarAsync();

        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = null,
            bool isTracking = false
        );

        TEntity ObterPorFiltro(
            Expression<Func<TEntity, bool>> filter = null,
            string includeProperties = null,
            bool isTracking = false
        );
        bool Adicionar(TEntity entity);
        bool Atualizar(TEntity entity);
        bool Remover(TEntity entity);
        int Salvar();
    }

    
}
