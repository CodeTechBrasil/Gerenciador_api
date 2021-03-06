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
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepository _repo;

        public TarefaService(ITarefaRepository repo) => _repo = repo;


        public async Task<bool> Adicionar(Tarefa objeto)
        {
            if (_repo.ObterTodos(c => c.Titulo.ToLower() == objeto.Titulo.ToLower()).Any())
            {
                return false;
            }
            await _repo.AdicionarAsync(objeto);
            return true;
        }

        public async Task Atualizar(Tarefa objeto) => await _repo.AtualizarAsync(objeto);


        public async Task<bool> Remover(Tarefa objeto)
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
