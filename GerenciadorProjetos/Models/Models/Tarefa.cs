using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public  class Tarefa
    {
        public int Id { get; set; }
        public string TuituloTarefa { get; set; }
        public string Descricao { get; set; }
        public Quadro Quadro { get; set; }
        public int QuadroId { get; set; }

    }
}
