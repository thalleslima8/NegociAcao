using NegociAcao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegociAcao.Controllers
{
    interface IOrdemController
    {
        void AdicionaOrdem(Ordem ordem);
    }
    class OrdemController : IOrdemController
    {
        public void AdicionaOrdem(Ordem ordem)
        {
            ;
        }
    }
}
