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
    public class TimeRepository: RepositoryNew<Time>, ITimeRepository
    {
        public TimeRepository(ApplicationDbContext db):base(db)
        {

        }
    }
}
