﻿using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Usuario : EntityBase
    {
        public Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }
    }
}
