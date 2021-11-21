using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public  class SubTarefa: EntityBase
    {
        public Tarefa Tarefa { get; set; }
        public string Nome { get; set; }
        public bool IsChecado { get; set; } = false;
    }
}
