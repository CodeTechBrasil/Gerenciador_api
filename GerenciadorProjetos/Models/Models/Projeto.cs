using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Projeto : EntityBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Time Time { get; set; }
        public int TimeId { get; set; }
        public int Status { get; set; }
        public DateTime DataIncio { get; private set; } = DateTime.Now;
        public DateTime DataFinal { get; set; }

        

    }
}
