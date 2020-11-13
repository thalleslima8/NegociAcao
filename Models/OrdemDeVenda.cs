using NegociAcao.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegociAcao.Models
{
    class OrdemDeVenda : Ordem
    {
        public TipoOrdem Tipo { get; set; }

        public OrdemDeVenda(TipoOrdem tipo)
        {
            Tipo = TipoOrdem.Venda;
        }

        public override string ToString()
        {
            return $"Dados da Ordem Id: {Id}:" +
                $"\r\nData: {Data}" +
                $"\r\nPapel: {Papel}" +
                $"\r\nValor Unitário: R$ {Valor}" +
                $"\r\nQuantidade: {Quantidade}" +
                $"\r\nValor Total: R$ {Volume()}" +
                $"\r\nTipo: {Tipo}";
        }
    }
}
