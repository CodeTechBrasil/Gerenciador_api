using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.IServices
{
    public interface IQuadroService : IDisposable
    {
        Task<bool> Adicionar(Quadro objeto);
        Task Atualizar(Quadro objeto);
        Task<bool> Remover(Quadro objeto);
    }
}
