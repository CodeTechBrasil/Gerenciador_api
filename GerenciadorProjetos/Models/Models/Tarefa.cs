using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public  class Tarefa : EntityBase
    {
        [Required(ErrorMessage = "O campo Titulo é Obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Descricao é Obrigatório")]
        public string Descricao { get; set; }

        public Quadro Quadro { get; set; }

        [Required(ErrorMessage = "O campo QuadroId é Obrigatório")]
        public int QuadroId { get; set; }

    }
}
