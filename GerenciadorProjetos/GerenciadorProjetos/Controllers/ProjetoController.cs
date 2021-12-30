using Business.Interfaces;
using Business.Interfaces.IRepository;
using Business.Interfaces.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System;
using System.Threading.Tasks;


namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase
    {
        private readonly IProjetoRepository _repo;
        private readonly IProjetoService _repoService;

        public ProjetoController(IProjetoRepository repo, 
                                 IProjetoService repoService)
        {
            _repo = repo;
            _repoService = repoService;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodosProjetos()
        {
            try
            {
                return Ok(await _repo.ObterTodosAsync());
            }catch(Exception e)
            {
                return BadRequest(new { message = "Erro ao listar os dados favor, verificar requisição" });
            }
            
        }


        [HttpPost]
        [Route("CadastrarProjeto")]
        public async Task<IActionResult> CadastrarProjeto([FromBody] Projeto objProjeto) 
        {

            if (!ModelState.IsValid)
                return BadRequest(new { message = "Favor Verifica as Informações" });

           await _repo.AdicionarAsync(objProjeto);
            await _repo.SalvarAsync();


            return Ok("");
        
        }

        
    }
}
