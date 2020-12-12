using System;

namespace Banco
{
    public abstract class Conta
    {
        public int Numero { get;  set; }

        public double Saldo { get; set; }

        public Clente Titular { get;  set; }

        public string ValorSacado { get;  set; }

    public Conta()
        {

        }

        public virtual void Deposita(double valorDeposito)
        {
            this.Saldo += valorDeposito;
        }
        public virtual void Sacar(double valorSaque)
        {
            if (Saldo >= valorSaque && valorSaque>=0)
            {
                this.Saldo -= valorSaque ;
            }
            this.ValorSacado = Convert.ToString(valorSaque);

        }

    }
}