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
    internal class UsuarioRepository : RepositoryNew<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
