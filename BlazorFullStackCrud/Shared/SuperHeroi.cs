using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFullStackCrud.Shared
{
    public class SuperHeroi
    {
        public int Id { get; set; }
        public string PrimeiroNome { get; set; } = string.Empty;
        public string UltimoNome { get; set; } = string.Empty;
        public string NomeDeHeroi { get; set; } = string.Empty;
        public Quadrinho? Quadrinho { get; set; }
        public int IdQuadrinho { get; set; }
    }
}
