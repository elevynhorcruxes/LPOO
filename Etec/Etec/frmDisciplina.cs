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
    public partial class frmDisciplina : Form
    {
        public frmDisciplina()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          try
            {
                DisciplinaDao disciplinaBD = new DisciplinaDao();
                Disciplina disciplinaReg = new Disciplina(int.Parse(txtcodigo.Text), txtNome.Text, int.Parse(txtcodigo.Text), txtNome.Text, int.Parse(txtcodAluno.Text), txtMencao.Text);

                disciplinaBD.AlterarDisciplina(disciplinaReg);
                MessageBox.Show("Registro alterado com sucesso.");
                btnAlterar.PerformClick();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
           
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Informe o nome da disciplina.");
                return;
            }
            try
            {
                DisciplinaDao disciplinaBD = new DisciplinaDao();
                Disciplina disciplinaReg = new Disciplina(txtNome.Text, int.Parse(txtcodAluno.Text), txtMencao.Text);

                disciplinaBD.IncluirDisciplina(disciplinaReg);
                MessageBox.Show("Registro salvo com sucesso.");
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            DisciplinaDao disciplinaBD = new DisciplinaDao();//instância da classe Alunos Dao
            //limpa os campos textbox do form
            txtcodigo.Text = "";
            txtNome.Text = "";
            txtcodAluno.Text = "";
            txtMencao.Text = "";

            //passa como parâmetro para o datagridview do form o retorno do getAlunos criado em AlunoDao
            dvgDisciplina.DataSouce = disciplinaBD.getDisciplina();
        }
    }
}
