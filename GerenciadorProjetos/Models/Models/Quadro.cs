using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Quadro
    {
        public int Id { get; set; }
        public string TituloQuadro { get; set; }
        public Etiqueta Etiqueta { get; set; }
        public int EtiquetaId { get; set; }

    }
}
