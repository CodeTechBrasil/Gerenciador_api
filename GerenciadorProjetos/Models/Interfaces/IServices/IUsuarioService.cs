using Models.Models;
using System;
using System.Threading.Tasks;

namespace Business.Interfaces.IServices
{
    public interface IUsuarioService : IDisposable
    {
        Task<bool> Adicionar(Usuario objeto);
        Task Atualizar(Usuario objeto);
        Task<bool> Remover(Usuario objeto);
    }
}
