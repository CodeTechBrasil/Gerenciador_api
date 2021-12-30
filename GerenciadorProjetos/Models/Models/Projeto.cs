using Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Projeto : EntityBase
    {
        [Required(ErrorMessage = "O campo nome é Obrigatório")]
   
        [MinLength(3, ErrorMessage = "Este campo tem que ter no minimo 3 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Descricao é Obrigatório")]
        public string Descricao { get; set; }

        public Time Time { get; set; }
        [Required(ErrorMessage = "O campo TimeId é Obrigatório")]
        public int TimeId { get; set; }
        [Required(ErrorMessage = "O campo nome é Obrigatório")]

        public int Status { get; set; }
        [Required(ErrorMessage = "O campo DataInicio é Obrigatório")]

        public DateTime DataIncio { get; private set; } = DateTime.Now;


        public DateTime DataFinal { get; set; } = DateTime.Now;




    }
}
