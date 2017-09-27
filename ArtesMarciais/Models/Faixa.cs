using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtesMarciais.Models
{
    public class Faixa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Grau { get; set; }

        /*public Faixa(int Id, string Nome, string Grau)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Grau = Grau;
        }*/
    }
}