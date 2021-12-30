using Business.Interfaces.IRepository;
using Business.Interfaces.IServices;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _repo;

        public PessoaService(IPessoaRepository repo) => _repo = repo;


        public async Task<bool> Adicionar(Pessoa objeto)
        {
            if (_repo.ObterTodos(c => c.Nome.ToLower() == objeto.Nome.ToLower()).Any())
            {
                return false;
            }
            await _repo.AdicionarAsync(objeto);
            return true;
        }

        public async Task Atualizar(Pessoa objeto) => await _repo.AtualizarAsync(objeto);


        public async Task<bool> Remover(Pessoa objeto)
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
