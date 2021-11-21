using Business.Interfaces;
using Business.Interfaces.IRepository;
using Business.Interfaces.IServices;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class EtiquetaService : IEtiquetaService
    {
        private readonly IEtiquetaRepository _repo;

        public EtiquetaService(IEtiquetaRepository repo)=> _repo = repo;
        

        public async Task<bool> Adicionar(Etiqueta objeto)
        {
            if (_repo.ObterTodos(c => c.Nome.ToLower() == objeto.Nome.ToLower()).Any())
            {
                return false;
            }
            await _repo.AdicionarAsync(objeto);
            return true;
        }

        public async Task Atualizar(Etiqueta objeto)=>  await _repo.AtualizarAsync(objeto);
        

        public async Task<bool> Remover(Etiqueta objeto)
        {
            var resultado = await _repo.ObterPorIdAsync(objeto.Id);
            if (resultado == null)
            {
                return false;
            }
            await _repo.RemoverAsync(objeto);
            return true;
        }

        public void Dispose() => _repo?.Dispose();


    }
}
