using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Etiqueta
    {
        public int Id { get; set; }
        public bool isNome { get; set; } = false;
        public string nome { get; set; }
        public string CorEtiqueta { get; set; }

    }
}
