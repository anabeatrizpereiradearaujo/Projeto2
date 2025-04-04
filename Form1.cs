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
        Thread nt;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Run(new ConteudoGeografia());
        }

        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Beatriz" && textBox2.Text == "2424")
            {

              
            }
               

            else
            {
                MessageBox.Show("Login ou senha inválidos.");
            }
        }
    }
}
