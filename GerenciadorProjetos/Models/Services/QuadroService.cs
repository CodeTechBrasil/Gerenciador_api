using Business.Interfaces.IRepository;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class QuadroService
    {
        private readonly IQuadroRepository _repo;

        public QuadroService(IQuadroRepository repo) => _repo = repo;


        public async Task<bool> Adicionar(Quadro objeto)
        {
            if (_repo.ObterTodos(c => c.Titulo.ToLower() == objeto.Titulo.ToLower()).Any())
            {
                return false;
            }
            await _repo.AdicionarAsync(objeto);
            return true;
        }

        public async Task Atualizar(Quadro objeto) => await _repo.AtualizarAsync(objeto);


        public async Task<bool> Remover(Quadro objeto)
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
