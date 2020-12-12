using System;

namespace Banco.Contas
{
    public abstract class Conta
    {
        public int Numero { get; set; }

        public double Saldo { get; set; }

        public Cliente Titular { get; set; }

        private static int numeroDeContas;

        public override string ToString()
        {
            return "Titular: " + this.Titular.Nome;
        }


        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }
        public static int LeitorConta()
        {
            return Conta.numeroDeContas;
        }
        public abstract void Deposita(double valorDeposito);
       // {
        //    this.Saldo += valorDeposito;
        //}

        public abstract bool Saca(double valorSaque);
        //{
          //  if (Saldo >= valorSaque)
            //{
              //  this.Saldo -= valorSaque;
                //return true;
            //}
            //return false;
        //}
    }
}