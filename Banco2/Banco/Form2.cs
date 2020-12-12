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
    public partial class Form2 : Form
    {
        private object formPrincipal;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta novaConta;

            if (comboTipoConta.SelectedItem == "Conta")
            {
                novaConta = new ContaCorrente();
            }
            else if (comboTipoConta.SelectedItem == "Conta Corrente")
            {
                novaConta = new ContaCorrente();
            }
            else
            {
                novaConta = new ContaPoupança();
            }
            novaConta.Numero = Convert.ToInt32(textBox1.Text);
            novaConta.Titular = new Clente(textBox1.Text);

            //////formPrincipal.AdicionaConta(novaConta);
            MessageBox.Show("Conta adicionada com sucesso !");
            this.Close();

        }


    }
}
