using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.IServices
{
    public interface ISubTarefaService : IDisposable
    {
        Task<bool> Adicionar(SubTarefa objeto);
        Task Atualizar(SubTarefa objeto);
        Task<bool> Remover(SubTarefa objeto);
    }
}
