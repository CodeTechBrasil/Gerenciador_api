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
    public class QuadroRepository : RepositoryNew<Quadro>, IQuadroRepository
    {
        public QuadroRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
