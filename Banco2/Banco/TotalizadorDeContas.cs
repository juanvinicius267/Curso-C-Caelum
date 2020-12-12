using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class TotalizadorDeContas
    {
        public double SaldoTotal { get; set; }

        public void Adiciona (Conta conta)
        {
            this.SaldoTotal += conta.Saldo;
        }
    }

}
