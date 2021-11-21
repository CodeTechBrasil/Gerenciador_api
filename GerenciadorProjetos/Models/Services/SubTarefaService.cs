using Business.Interfaces.IRepository;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class SubTarefaService
    {
        private readonly ISubTarefaRepository _repo;

        public SubTarefaService(ISubTarefaRepository repo) => _repo = repo;


        public async Task<bool> Adicionar(SubTarefa objeto)
        {
            if (_repo.ObterTodos(c => c.Nome.ToLower() == objeto.Nome.ToLower()).Any())
            {
                return false;
            }
            await _repo.AdicionarAsync(objeto);
            return true;
        }

        public async Task Atualizar(SubTarefa objeto) => await _repo.AtualizarAsync(objeto);


        public async Task<bool> Remover(SubTarefa objeto)
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
