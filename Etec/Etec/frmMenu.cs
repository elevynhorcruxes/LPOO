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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();//fecha a tela aberta
            frmAlunos abre = new frmAlunos();//tela de alunos
            abre.ShowDialog();//abre a nova tela
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();//fecha a tela aberta
            frmDisciplina mostra = new frmDisciplina();//tela de disciplina
            mostra.ShowDialog();//abre a nova tela
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
