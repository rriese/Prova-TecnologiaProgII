﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtesMarciais.Models
{
    public class TipoDeAssociacao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Periodo { get; set; }
        public int Mensalidade { get; set; }
    }
}