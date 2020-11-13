using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegociAcao.Models
{
    public abstract class Ordem
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Papel { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        
        public decimal Volume()
        {
            return Valor * Quantidade;
        }

        public string ToCSV()
        {
            return $"{Id};{Data};{Papel};{Valor};{Quantidade};{Volume()}";
        }


    }
}
