using Business.Interfaces.IRepository;
using DataAccess.context;
using Models.Models;

namespace DataAccess.Repository
{
    public class ProjetoRepository : RepositoryNew<Projeto>, IProjetoRepository
    {
        public ProjetoRepository(ApplicationDbContext db) : base(db) { }
    }
}
