using Business.Interfaces.IRepository;
using Business.Interfaces.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System.Threading.Tasks;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        private readonly ITimeRepository _repo;
        private readonly ITimeService _service;
        public TimeController(ITimeRepository repo, ITimeService service)
        {
            _repo = repo;
            _service = service;

        }

        [HttpPost]
        [Route("CadastrarTime")]
        public async Task<IActionResult> CadastrarTime([FromBody] Time objTime)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            await _repo.AdicionarAsync(objTime);
            await _repo.SalvarAsync();
            return Ok();
        }
    }
}
