using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Quadro : EntityBase
    {
        [Required(ErrorMessage = "O campo Titulo é Obrigatório")]
        public string Titulo { get; set; }
        public Etiqueta Etiqueta { get; set; }
        public int Status { get; set; }

        [Required(ErrorMessage = "O campo EtiquetaId é Obrigatório")]
        public int EtiquetaId { get; set; }

    }
}
