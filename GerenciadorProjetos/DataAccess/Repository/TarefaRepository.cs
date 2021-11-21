using Business.Interfaces.IRepository;
using Business.Models;
using DataAccess.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class TarefaRepository : RepositoryNew<Tarefa>, ITarefaRepository
    {
        public TarefaRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
