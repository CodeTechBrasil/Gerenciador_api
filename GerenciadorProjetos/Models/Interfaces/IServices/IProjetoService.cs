using Models.Models;
using System;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IProjetoService : IDisposable
    {
        Task<bool> Adicionar(Projeto objeto);
        Task Atualizar(Projeto objeto);
        Task<bool> Remover(Projeto objeto);
    }
}