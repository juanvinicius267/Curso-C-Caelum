using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    public class Cliente
    {
        
        public string nome { get; set; }

        public string cpf { get; set; }

        public string rg { get; set; }

        public string endereço { get; set; }

        public int idade { get; set; }

        public bool checkAge(int idade)
        {
            this.idade = idade;
            return (idade >= 18 ?  true :  false);

        }
        public Cliente (string nome, string rg)
        {
            this.rg = rg;
            this.nome = nome;
        }
        public Cliente( string rg)
        {
            this.rg = rg;
           
        }

    }
}
