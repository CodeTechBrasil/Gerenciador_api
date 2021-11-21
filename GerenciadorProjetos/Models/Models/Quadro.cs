using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Quadro : EntityBase
    {
        public string Titulo { get; set; }
        public Etiqueta Etiqueta { get; set; }
        public int Status { get; set; }
        public int EtiquetaId { get; set; }

    }
}
