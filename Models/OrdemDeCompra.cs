using NegociAcao.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegociAcao.Models
{
    class OrdemDeCompra : Ordem
    {
        public TipoOrdem Tipo { get; set; }

        public OrdemDeCompra(TipoOrdem tipo)
        {
            Tipo = TipoOrdem.Compra;
        }


    }
}
