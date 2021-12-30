using Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Usuario : EntityBase
    {
        public Pessoa Pessoa { get; set; }
        [Required(ErrorMessage = "O campo PessoaId é Obrigatório")]
        public int PessoaId { get; set; }
    }
}
