using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public  class SubTarefa: EntityBase
    {
        public Tarefa Tarefa { get; set; }
        [Required(ErrorMessage = "O campo nome é Obrigatório")]
        public string Nome { get; set; }
        public bool IsChecado { get; set; } = false;
    }
}
