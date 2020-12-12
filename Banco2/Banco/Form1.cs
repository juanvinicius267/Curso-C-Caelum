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
    public partial class Form1 : Form
    {
        private ContaCorrente[] contas;
        private int numeroDeContas;

        public object TextoIndice { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new ContaCorrente[3];

            this.contas[0] = new ContaCorrente();
            this.contas[0].Titular = new Clente("Victor");
            this.contas[0].Numero = 1;

            this.contas[1] = new ContaCorrente();
            this.contas[1].Titular = new Clente("Otavio");
            this.contas[1].Numero = 2;

            this.contas[2] = new ContaCorrente();
            this.contas[2].Titular = new Clente("Hugo");
            this.contas[2].Numero = 3;
            foreach (Conta conta in contas)
            {
                comboContas.Items.Add("Titular: " + conta.Titular.Nome);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(TextoIndice);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //double valorSaque = Convert.ToDouble(TextoValor.Text);
            //novaConta.Sacar(valorSaque);
            //TextoSaldo.Text = Convert.ToString(this.novaConta.Saldo);
            //Text_Valor_Sacado.Text = novaConta.ValorSacado;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TotalizadorDeContas td = new TotalizadorDeContas();
            Conta c1 = new ContaCorrente();
            Conta c2 = new ContaCorrente();
            Conta c3 = new ContaCorrente();
            Conta c4 = new ContaCorrente();
            c1.Deposita(1000);
            c2.Deposita(1000);
            c3.Deposita(1000);
            c4.Deposita(1000);
            td.Adiciona(c1);
            td.Adiciona(c2);
            td.Adiciona(c3);
            td.Adiciona(c4);
            MessageBox.Show("O saldo total é: " + td.SaldoTotal);
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            TextoNumero.Text = Convert.ToString(selecionada.Numero);
            TextoSaldo.Text = Convert.ToString(selecionada.Saldo);
            TextoTitular.Text = selecionada.Titular.Nome;

            foreach (Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular.Nome);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           Form2 formCadastro =  new Form2();
            formCadastro.ShowDialog();
        }
        public void AdicionaConta(Conta novaConta)
        {
            //contas[numeroDeContas];
        }
    }
}
