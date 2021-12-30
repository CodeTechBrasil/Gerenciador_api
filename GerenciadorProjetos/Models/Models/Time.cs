using Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Time : EntityBase
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é Obrigatório")]
        public string Nome { get; set; }

    }
}
