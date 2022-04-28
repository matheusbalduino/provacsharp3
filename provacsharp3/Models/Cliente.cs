using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace provacsharp3.Models
{
    public class Cliente
    {
        public long Cliente_id { get; set; }
        public int Idade { get; set; }
        public decimal Peso { get; set; }
        public string Nome { get; set; }
        public string Profissao { get; set; }
        public string Cpf { get; set; }
    }
}
