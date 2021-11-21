using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.IServices
{
    public interface ITimeService : IDisposable
    {
        Task<bool> Adicionar(Time objeto);
        Task Atualizar(Time objeto);
        Task<bool> Remover(Time objeto);
    }
}
