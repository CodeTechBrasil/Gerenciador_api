using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public Pessoa pessoas { get; set; }
        public int pessoaId { get; set; }
    }
}
