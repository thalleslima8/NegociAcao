using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegociAcao.Models
{
    abstract class Ordem
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Papel { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        
        public double Volume()
        {
            return Valor * Quantidade;
        }

    }
}
