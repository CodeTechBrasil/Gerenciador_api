using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.IServices
{
    public interface ITarefaService : IDisposable
    {
        Task<bool> Adicionar(Tarefa objeto);
        Task Atualizar(Tarefa objeto);
        Task<bool> Remover(Tarefa objeto);
    }
}
