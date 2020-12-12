using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaPoupança : Conta
    {
        public override void Sacar(double valorSaque)
        {
            valorSaque +=  0.1;
            base.Sacar(valorSaque) ;
        }
    }
}
