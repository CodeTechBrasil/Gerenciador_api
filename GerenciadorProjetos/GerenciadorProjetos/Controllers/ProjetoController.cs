using Business.Interfaces;
using Business.Interfaces.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{

    [ApiController]
    public class ProjetoController : Controller
    {
        private readonly IProjetoRepository _repo;
        private readonly IProjetoService _repoService;

        public ProjetoController(IProjetoRepository repo, 
                                 IProjetoService repoService)
        {
            _repo = repo;
            _repoService = repoService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
