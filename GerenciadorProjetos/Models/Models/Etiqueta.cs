using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Etiqueta: EntityBase
    {
        public bool IsNome { get; set; } = false;
        public string Nome { get; set; }

        [Required(ErrorMessage =  "Cor é obrigatória")]
        public string CorEtiqueta { get; set; }

    }
}
