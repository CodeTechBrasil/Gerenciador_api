using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.IServices
{
    public interface IEtiquetaService : IDisposable
    {
        Task<bool> Adicionar(Etiqueta objeto);
        Task Atualizar(Etiqueta objeto);
        Task<bool> Remover(Etiqueta objeto);
    }
}
