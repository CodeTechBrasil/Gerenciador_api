using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Pessoa: EntityBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Funcao { get; set; }
        public Time Time { get; set; }
        public int TimeId { get; set; }
    }
}
