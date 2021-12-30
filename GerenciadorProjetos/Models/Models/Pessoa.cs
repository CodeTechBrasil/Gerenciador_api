using Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Pessoa: EntityBase
    {
        [Required (ErrorMessage = "O campo nome é Obrigatório")]
        [MaxLength (10,ErrorMessage ="Este campo tem que conter entre 3 a 10 caracteres")]
        [MinLength(3, ErrorMessage ="Este campo tem que conter entre 3 a 10 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo sobrenome é Obrigatório")]
        [MinLength(3, ErrorMessage = "Este campo tem que conter no minimo 3  caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "O campo Funcao é Obrigatório")]
        public string Funcao { get; set; }

        public Time Time { get; set; }
        [Required(ErrorMessage = "O campo TimeId é Obrigatório")]
        public int TimeId { get; set; }
    }
}
