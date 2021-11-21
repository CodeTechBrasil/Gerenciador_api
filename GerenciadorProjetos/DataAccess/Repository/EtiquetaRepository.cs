using Business.Interfaces;
using Business.Models;
using DataAccess.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class EtiquetaRepository : RepositoryNew<Etiqueta>, IEtiquetaRepository
    {
        public EtiquetaRepository(ApplicationDbContext db):base(db){}
    }
}
