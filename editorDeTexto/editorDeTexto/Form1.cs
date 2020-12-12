using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace editorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void textoConteudo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Stream entrada = File.Open("text.txt", FileMode.Open);
            //StreamReader leitor = new StreamReader(entrada);
            //textoConteudo.Text = leitor.ReadToEnd();
            //leitor.Close();
            //entrada.Close();
            using (Stream entrada = File.Open("text.txt", FileMode.Open))
            using (StreamReader leitor = new StreamReader(entrada))
            {
                textoConteudo.Text = leitor.ReadToEnd();
            }

        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            //Stream entrada = File.Open("text.txt", FileMode.Create);
            //StreamWriter escritor = new StreamWriter(entrada);
            //escritor.Write(textoConteudo.Text);
            //escritor.Close();
            //entrada.Close();
            using (Stream entrada = File.Open("text.txt", FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(entrada))
            {
                escritor.Write(textoConteudo.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string busca = textBox1.Text;
            string textoDoEditor = textBox2.Text;
            int resultado = textoDoEditor.IndexOf(busca);
            if (resultado >= 0 )
            {
                MessageBox.Show("Achei o texto" + busca);
            }
            else
            {
                MessageBox.Show("Nao achei!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string busca2 = "jor";
               string busca = textBox1.Text;
            string textoDoEditor = textBox2.Text;
            string resultado = textoDoEditor.Replace(busca, busca2);
            if (resultado == "j")
            {
                MessageBox.Show("Achei o texto" + busca);
            }
            else
            {
                MessageBox.Show("Nao achei!");
            }
        }
    }
}
