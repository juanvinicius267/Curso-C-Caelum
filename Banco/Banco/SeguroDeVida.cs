using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;
namespace Banco
{
    public class SeguroDeVida : ITributavel
    {
        public double CalcularTributos()
        {
            return 42.0;
        }
    }
}
