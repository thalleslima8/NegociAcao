using DotLiquid.Tags;
using NegociAcao.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegociAcao.Models
{
    public class OrdemDeCompra : Ordem
    {
        public TipoOrdem Tipo { get; set; }

        public OrdemDeCompra(TipoOrdem tipo)
        {
            Tipo = TipoOrdem.Compra;
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
