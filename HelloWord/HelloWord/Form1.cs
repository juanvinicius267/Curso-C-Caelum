using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeJuan = 20;
            int idadeGabriel = 32;
            int soma = idadeGabriel; /*int media = (idadeJuan + idadeGabriel) / 2;*/
            soma += idadeJuan;
            int media = soma / 2;
            MessageBox.Show("A media é: " + media);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idadeJoao = 10;
            int idadeMaria = 25;
            int idadeRicardo = 20;
            int media = (idadeJoao + idadeMaria + idadeRicardo) / 3;
            MessageBox.Show("A media é: " + media);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int a = 2;
            int b = 20;
            int c = 1;
            double delta = (b * b) - (4 * a * c);
            double delta2 = (Math.Sqrt(delta));
            MessageBox.Show("Valor de delta " + delta);
            double a1 = (-b + delta / (2 * a));
            double a2 = (-b - delta / (2 * a));
            MessageBox.Show("Valores de A1 " + a1 + " e A2 " + a2);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado " + piQuebrado);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 100.0;
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso " + saldo);
            }
            else
            {
                MessageBox.Show("Saldo Insulficiente" + saldo);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double taxa = 0.0;
            double saldo = 100.0;
            if (saldo < 1000)
            {
                taxa = 0.01;
            }
            else if (saldo <= 5000)
            {
                taxa = 0.05;
            }
            else if (saldo > 5000)
            {
                taxa = 0.1;
            }
            MessageBox.Show("A Taxa é " + taxa);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            if (saldo < 0.0)
            {
                MessageBox.Show("Você estano negativo");

            }
            else if (saldo < 1000000.0)
            {
                MessageBox.Show("Você é um bom cliente!");

            }
            else
            {
                MessageBox.Show("Você é milionario");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool brasileiro = true;
            int idade = 15;
            if (idade >= 16 && brasileiro)
            {
                MessageBox.Show("Pode Votar !");
            }
            else
            {
                MessageBox.Show("Não pode votar");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 7000.0;
            double imposto;
            if (valorDaNotaFiscal <= 999.0)
            {
                imposto = 0.02;
                imposto *= valorDaNotaFiscal;
                MessageBox.Show("Valor do imposto a pagar é " + imposto);
            }
            else if (valorDaNotaFiscal >= 1000 && valorDaNotaFiscal <= 1999)
            {
                imposto = 0.025;
                imposto *= valorDaNotaFiscal;
                MessageBox.Show("Valor do imposto a pagar é " + imposto);
            }
            else if (valorDaNotaFiscal >= 3000 && valorDaNotaFiscal <= 6999)
            {
                imposto = 0.028;
                imposto *= valorDaNotaFiscal;
                MessageBox.Show("Valor do imposto a pagar é " + imposto);
            }
            else if (valorDaNotaFiscal >= 7000)
            {
                imposto = 0.03;
                imposto *= valorDaNotaFiscal;
                MessageBox.Show("Valor do imposto a pagar é " + imposto);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int valor = 9;

            //if TERNARIO
            MessageBox.Show(valor > 10 ? "Maior que dez" : "Menor que dez");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int idade = 1;
            while (idade < 100)
            {
                MessageBox.Show("A idade é " + idade);
                idade++;
            }
            for (int idade2 = 1; idade2 < 100; idade2++) {
                if (idade2 ==32)
                {
                    continue;// Pula o valor do laço
                    break; // quebra o Laço
                }
                MessageBox.Show("Idade é " + idade2);
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int total = 2;
            for (int i = 0; i < 5; i+= 1)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é:" + total);
        }

        private void button13_Click(object sender, EventArgs e)
        { // O % DEVOLVE O RESTO DE UMA DIVISÃO
            for (int i = 1; i < 1000; i+= 3)
            {
                if (i % 3 == 0)
                {
                    MessageBox.Show("Multiplo de 3" + i);
                }
                
            }
        }
        

        private void button14_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.Deposita(1000);
            MessageBox.Show("Test "+ conta.Saca(1000,18));

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            Conta conta2 = new Conta();
            conta.Deposita(300);
            conta2.Deposita(300);
            conta.Transfere(conta2, 1200, 18);
            MessageBox.Show("Test "+ conta2.saldo);
        }

        private void button16_Click(object sender, EventArgs e)
        { 
            Conta conta = new Conta();
            Conta conta2 = new Conta();
            conta.Deposita(300);
            conta2.Deposita(300);
            conta.Deposita(200);
            MessageBox.Show("Test " + conta.saldo);
            conta2.Saca(200, 19);
            MessageBox.Show("Test " + conta2.saldo);
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var c = new Cliente("50");
            c.idade = 9;
           
            MessageBox.Show("É: "+c.rg + c.nome);
           
        }
    }
}
