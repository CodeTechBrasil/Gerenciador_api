using Business.Interfaces;
using Business.Interfaces.IRepository;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ProjetoService : IProjetoService
    {
        // NOS SERVIÇOS NÃO SE FAZ CONSULTA E SIM MANIPULAÇÃO, TIPO ADICIONAR, ATUALIZAR E EXCLUIR

        //CONSULTA VAI DIRETO NO CONTROLE
        private readonly IProjetoRepository _repo;

        public ProjetoService(IProjetoRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Adicionar(Projeto objeto)
        {
            //Se tiver uma lógica de validação coloca-se antes
            if(_repo.ObterTodos(c=> c.Nome.ToLower() == objeto.Nome.ToLower()).Any())
            {
                //Já existe um registro com o nome
                return false;
            }
            await _repo.AdicionarAsync(objeto);
            return true;
        }

        public async Task Atualizar(Projeto objeto)
        {
            await _repo.AtualizarAsync(objeto);
        }

        

        public async Task<bool> Remover(Projeto objeto)
        {
            //Se tiver uma lógica de validação coloca-se antes
            var resultado = await _repo.ObterPorIdAsync(objeto.Id);
            if (resultado == null)
            {
                //Não existe registro para excluir
                return false;
            }
            await _repo.RemoverAsync(objeto);
            return true;
        }

        public void Dispose() => _repo?.Dispose();
    }
}
