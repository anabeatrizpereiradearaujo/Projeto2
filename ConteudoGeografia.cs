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
    public partial class ConteudoGeografia : Form
    {
        public ConteudoGeografia()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            ConteudoGeografia formConteudo = new ConteudoGeografia();
            formConteudo.Show();

            this.Close();
        }
    }
}
