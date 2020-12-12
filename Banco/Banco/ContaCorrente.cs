using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;

namespace Banco
{
    public class ContaCorrente : Conta, ITributavel
    {
        public override bool Saca(double valorSaque)
        {
            if (valorSaque<0 )
            {
                throw new SaldoInsulficienteException();
            }
            if (valorSaque>Saldo)
            {
                throw new SaldoInsulficienteException();
            }
            double taxaSaque = 0.05;
            if (this.Saldo >= valorSaque)
            {
                this.Saldo -= (valorSaque + taxaSaque);
                return true;
            }
            else return false;
        }

        public override void Deposita(double valorDeposito)
        {
            double taxaDeposito = 0.10;
            this.Saldo += (valorDeposito - taxaDeposito);
            //base.Deposita(valorDeposito - taxaDeposito);
        }

        public double CalcularTributos()
        {
           return  Saldo * 0.05;
           
        }
    }
}
