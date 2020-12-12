using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HelloWord
{
    public  class Conta 
    {
        public double saldo { get; private set; }

        public int numero { get; set; }

        public Cliente titular { get; set; }
               

        public bool Saca(float valor, int idade)
        {
            if (this.saldo >= valor && idade >= 18 && this.saldo > 0)
            {
                this.saldo -= valor;
                return true;
            }
            else if (this.saldo >= valor && idade < 18 && this.saldo > 0)
            {
                if (valor <= 200.0 )
                {
                    this.saldo -= valor;
                    return true; 
                }
                else
                {
                    return false;
                    
                }
            }
            return false;
        }
        public bool Deposita (float valor)
        {
            this.saldo += valor;
            return true;
        }
        public bool Transfere(Conta destino, float valor, int idade)
        {
            if (this.Saca(valor,idade))
            {
                destino.Deposita(valor);
                return true;
            }
            return false;
        }
    }
}
