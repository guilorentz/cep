﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CEP.Models
{
    public class Pais
    {
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}
