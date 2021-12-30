using Business.Interfaces.IRepository;
using DataAccess.context;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UsuarioRepository : RepositoryNew<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
