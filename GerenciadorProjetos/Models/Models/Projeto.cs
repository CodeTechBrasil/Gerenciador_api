using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string NomeProjeto { get; set; }
        public string Descricao { get; set; }
        public Time Time { get; set; }
        public int TimeId { get; set; }
        public DateTime DateInio { get; private set; } = DateTime.Now;
        public DateTime DateFinal { get; set; }

        

    }
}
