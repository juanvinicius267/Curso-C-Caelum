using Banco.Contas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        //  private Conta novaConta; -  exercício 11.2.4
        private Dictionary<string, Conta> dicionario;
        private List<Conta> contas ;
        private int numeroDeContas;
        Conta conta = new ContaCorrente();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas[2] = new ContaCorrente();
            this.contas[2].Titular = new Cliente("Osni");
            this.contas[2].Numero = 3;


            //ContaPoupanca c2 = new ContaPoupanca();
            //c2.Deposita(2000);
            //c1.Titular.Nome = "RUAN";
            //ContaCorrente c3 = new ContaCorrente();
            //c3.Deposita(3000);
            //c1.Titular.Nome = "JHUAN";
            this.dicionario = new Dictionary<string, Conta>();
            //carregado quando algum evento for gerado
            //exercício 10.4.6 this.novaConta = new ContaPoupanca(); 
            // this.novaConta = new ContaCorrente(); // exercício 10.4.7
            // this.novaConta.Numero = 1;
            // this.novaConta.Titular = new Cliente("Gabriel");
            // exercício 11.2.4
            this.contas = new List<Conta>();
            //this.contas[0] = new ContaPoupanca();
            //this.contas[0].Titular = new Cliente("Victor");
            //this.contas[0].Numero = 1;
            //numeroDeContas++;
            

            //this.contas[1] = new ContaPoupanca();
            //this.contas[1].Titular = new Cliente("Mauricio");
            //this.contas[1].Numero = 2;
            //numeroDeContas++;

            //this.contas[2] = new ContaCorrente();
            //this.contas[2].Titular = new Cliente("Osni");
            //this.contas[2].Numero = 3;
            //numeroDeContas++;

            foreach (Conta c in this.contas)
            {
                if (c != null)
                {
                comboContas.Items.Add(c);
                }
            }

            
            //int indice = Convert.ToInt32(textoIndice.Text);

            //textoNumero.Text = Convert.ToString(this.novaConta[indice].Numero);
            //textoTitular.Text = this.novaConta[indice].Titular.Nome;
            //textoSaldo.Text = Convert.ToString(this.novaConta[indice].Saldo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // double valorDeposito = Convert.ToDouble(textoValor.Text);
            // novaConta.Deposita(valorDeposito);

            // textoSaldo.Text = Convert.ToString(this.novaConta.Saldo);

            // exercicio 11.2.4
         
            try
            {
                Conta selecionada = (Conta) comboContas.SelectedItem; // recuperar o índice da conta selecionada
            
                // e depois ler a posição correta do array
                //Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(textoValor.Text);
            
                selecionada.Deposita(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            }
            catch (Exception)
            {
                MessageBox.Show("Você não pode depositar valor negativo!");
               
                
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // double valorSaque = Convert.ToDouble(textoValor.Text);
            // novaConta.Saca(valorSaque);

            // textoSaldo.Text = Convert.ToString(this.novaConta.Saldo);

            //exercício 11.2.4
            try
            {
                int indice = comboContas.SelectedIndex;

                Conta selecionada = this.contas[indice];

                double valor = Convert.ToDouble(textoValor.Text);
                selecionada.Saca(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            }
            catch (SaldoInsulficienteException)
            {

                MessageBox.Show("Deu merda!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //exercício 10.4.8
            TotalizadorDeContas td = new TotalizadorDeContas();

            Conta c1 = new ContaCorrente();
            c1.Deposita(1000);

            ContaPoupanca c2 = new ContaPoupanca();
            c2.Deposita(2000);

            ContaCorrente c3 = new ContaCorrente();
            c3.Deposita(3000);

            td.Adiciona(c1);
            td.Adiciona(c2);
            td.Adiciona(c3);

            MessageBox.Show("Saldo Total das contas = " + td.SaldoTotal);
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            //exercício 11.2.4
            //int indice = Convert.ToInt32(textoIndice.Text);
            //Conta selecionada = this.contas[indice];
            //textoNumero.Text = Convert.ToString(selecionada.Numero);
            //textoTitular.Text = selecionada.Titular.Nome;
            //textoSaldo.Text = Convert.ToString(selecionada.Saldo);

            string nomeTitular = textoTitular.Text;
            Conta conta = dicionario[nomeTitular];
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoTitular.Text = conta.Titular.Nome;
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            comboContas.SelectedItem = conta;
        }
        

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro(this);
            formCadastro.ShowDialog();
        }

        public void AdicionaConta(Conta conta)
        {
            contas.Add(conta);
            comboContas.Items.Add(conta);
            this.dicionario.Add(conta.Titular.Nome, conta);
            //this.contas.Add(conta);
            //comboContas.Items.Add(conta);
            
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            
            //TotalizadorDeContas totalizador = new TotalizadorDeContas();
            //foreach (Conta item in this.contas)
            //{
            //    if (contas is ContaCorrente)
            //    {
            //        ContaCorrente cc = (ContaCorrente)contas;
            //        totalizador.Adiciona(((ContaCorrente)contas));
            //    }
                
            //}
            //ContaCorrente conta = new ContaCorrente();
            //conta.Deposita(200.0);
            //SeguroDeVida sv = new SeguroDeVida();
            //TotalizadorDeTributos totalizadorDeTributos = new TotalizadorDeTributos();
            //totalizadorDeTributos.Adiciona(conta);
            //MessageBox.Show("Total: " + totalizadorDeTributos.Total);
            //totalizadorDeTributos.Adiciona(sv);
            //MessageBox.Show("Total: " + totalizadorDeTributos.Total);
            //ITributavel t = conta;
            //MessageBox.Show(" Imposto da conta pela conta corrente: " + conta.CalcularTributos());
            //MessageBox.Show("Imposto da conta pela interface" + t.CalcularTributos());

            //t = sv;
            //MessageBox.Show("Imposto da conta pela interface" + t.CalcularTributos());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // botao relatorio

            FormRelatorios form = new FormRelatorios(this.contas);
            form.ShowDialog();
            var conta = new ContaCorrente();
            var lista = conta.where(conta => conta.saldo > 5000)
                orderby(conta => cconta.titular.Nome)
                .thenby(conta => conta.Numero)
                .thenby(conta => conta.saldo);
        }
    }
}
