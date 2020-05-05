using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etec
{
    public partial class Abertura : Form
    {
        public Abertura()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            { //vai aparecendo o progressoBar1 conforme preencher o componente da tela.
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                timer1.Enabled = false;//desativar o timer
                this.Hide();//fecha a tela ativa
                frmLogin abre = new frmLogin();//tela de login
                abre.ShowDialog();//abre a tela do login
            }

        }
    }
}
