using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class GeradorDeDevedores
    {
        //public List<string> GeraList()
        //{
        //    List<string> nomes = new List<string>();
        //    for (int i = 0; i < 30000; i++)
        //    {
        //        nomes.Add("deverdor" + i);
        //    }
        //    return nomes;
        //}
        //public HashSet<string> GeraList()
        //{
        //    HashSet<string> nomes = new HashSet<string>();
        //    for (int i = 0; i < 30000; i++)
        //    {
        //        nomes.Add("deverdor" + i);
        //    }
        //    return nomes;
        //}
         
        public SortedSet<string> GeraList()
        {
            SortedSet<string> nomes = new SortedSet<string>();
            for (int i = 0; i < 30000; i++)
            {
                nomes.Add("deverdor" + i);
            }
            return nomes;
        }
    }
}
