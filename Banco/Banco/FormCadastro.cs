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
    public partial class FormCadastro : Form
    {
        private ICollection<string> devedores;
        private Form1 form1;
        public FormCadastro(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }

        private Form1 formPrincipal;

        public void FormCadastro1(Form1 form1)
        {
            InitializeComponent();
            this.formPrincipal = form1;
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            string titular = textoTitular.Text;
            bool EhDevedor = this.devedores.Contains(titular);
            if (!EhDevedor)
            {
                Conta novaConta;
                if (comboTipoConta.SelectedItem == "Conta")
                {
                    novaConta = new ContaPoupanca();
                }
                else if (comboTipoConta.SelectedItem == "Conta corrente")
                {
                    novaConta = new ContaCorrente();
                }
                else
                {
                    novaConta = new ContaPoupanca();
                }

                novaConta.Numero = Convert.ToInt32(textoNumero.Text);
                novaConta.Titular = new Cliente(textoTitular.Text);

                formPrincipal.AdicionaConta(novaConta);

                MessageBox.Show("Conta adicionada com sucesso.");
                this.Close();
            }
            else
            {
                MessageBox.Show("É devedor!!!!!");
            }
            
        }

        private void tipoDeConta_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textoNumero_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            textoNumero.Text = Convert.ToString(Conta.LeitorConta());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
