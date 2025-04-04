using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Beatriz" && textBox2.Text == "2424") // Verifica login e senha
            {
                MessageBox.Show("Bem-vindo ao sistema!");

                Form2 formConteudo = new Form2(); 
                formConteudo.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos.");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
