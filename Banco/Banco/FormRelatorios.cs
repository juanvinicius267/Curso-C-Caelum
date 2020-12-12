using Banco.Contas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormRelatorios : Form
    {
        private List<Conta> contas;

        public FormRelatorios(List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxResultados.Items.Clear();
            var resultado = from c in contas
                            where c.Saldo >5000
                            select c;
            foreach (var c in resultado)
            {
                listBoxResultados.Items.Add(c);
            }
        }
    }
}
