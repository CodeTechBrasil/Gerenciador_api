using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public  class SubTarefa
    {
        public int Id { get; set; }
        public Tarefa Tarefa { get; set; }
        public string NomeSubTarefa { get; set; }
        public bool IsCheck { get; set; } = false;
    }
}
