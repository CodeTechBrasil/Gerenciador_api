using Business.Interfaces.IRepository;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UsuarioService
    {
        private readonly IUsuarioRepository _repo;

        public UsuarioService(IUsuarioRepository repo) => _repo = repo;


        public async Task<bool> Adicionar(Usuario objeto)
        {
            if (_repo.ObterTodos(c => c.Pessoa.Nome.ToLower() == objeto.Pessoa.Nome.ToLower()).Any())
            {
                return false;
            }
            await _repo.AdicionarAsync(objeto);
            return true;
        }

        public async Task Atualizar(Usuario objeto) => await _repo.AtualizarAsync(objeto);


        public async Task<bool> Remover(Usuario objeto)
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
