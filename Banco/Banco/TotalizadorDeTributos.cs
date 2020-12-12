using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;
namespace Banco
{
    public class TotalizadorDeTributos
    {
        public double Total { get; set; }

        public void Adiciona(ITributavel t)
        {
            this.Total += t.CalcularTributos();
            
        }





    }
}
