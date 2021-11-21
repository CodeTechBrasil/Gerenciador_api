using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.IServices
{
    public interface IPessoaService : IDisposable
    {
        Task<bool> Adicionar(Pessoa objeto);
        Task Atualizar(Pessoa objeto);
        Task<bool> Remover(Pessoa objeto);
    }
}
