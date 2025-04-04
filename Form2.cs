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

    public partial class Form2: Form
    {

        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

                Form2 formConteudo = new Form2();
                formConteudo.Show();

                this.Close();
            
        }


            private void btnSair_Click(object sender, EventArgs e)
            {
              Application.Exit();

            }
        



    }


}
