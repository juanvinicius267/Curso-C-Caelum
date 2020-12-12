using Banco.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    //exercício 10.4.4
    public class ContaPoupanca : Conta
    {
        public override bool Saca(double valorSaque)
        {
            
            double taxaSaque = 0.10;

            if (this.Saldo >= valorSaque)
            {
                this.Saldo -= (valorSaque + taxaSaque);
                return true;
            }
            else return false;
        }

        public override void Deposita(double valorDeposito)
        {
            if (valorDeposito < 0.0)
            {
                throw new ArgumentException();
            }
            this.Saldo += valorDeposito;
        }
    }
}
