using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaCorrente : Conta
    {
        public override void Sacar(double valorSaque)
        {
            base.Sacar(valorSaque + 0.5);
        }
        public override void Deposita(double valorDeposito)
        {
            base.Deposita(valorDeposito +0.1);
        }
    }
}
