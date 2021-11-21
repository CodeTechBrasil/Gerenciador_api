using Business.Interfaces.IRepository;
using Business.Models;
using DataAccess.context;

namespace DataAccess.Repository
{
    public class SubTarefaRepository: RepositoryNew<SubTarefa>, ISubTarefaRepository
    {
        public SubTarefaRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
