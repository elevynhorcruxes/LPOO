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
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//botão salvar
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Informe o nome do aluno.");
                return;
            }
            try
            {
                AlunosDao alunoBD = new AlunosDao();
                Alunos alunoReg = new Alunos(txtNome.Text, txtEndereco.Text, int.Parse(txtIdade.Text), txtcaminho.Text);
                alunoBD.IncluirAluno(alunoReg);//chamada do método
                MessageBox.Show("Registro salvo com sucesso.");
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {//carrega foto
            abrefoto.Title = "Selecione a foto";
            //Diretorio
            abrefoto.InitialDirectory = "F:\\2º Info\\Ensino Técnico\\LPOOOOOOOOOOOOOOO\\3º Bimestre\\Imagens\\Pessoas";
            abrefoto.Filter = "JPEG|*.JPG|PNG|*.png";
            abrefoto.ShowDialog();

            fotoi.Image = Image.FromFile(abrefoto.FileName);
            txtcaminho.Text = abrefoto.FileName.Replace(@"\", @"\\");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                AlunosDao alunoBD = new AlunosDao();
                Alunos alunoReg = new Alunos(int.Parse(txtID.Text), txtNome.Text, txtEndereco.Text, int.Parse(txtIdade.Text), txtcaminho.Text.Replace(@"\", @"\\"));
                //replace substitui \ por \\ para salvar
                alunoBD.AlterarAluno(alunoReg);
                MessageBox.Show("Registro alterado com sucesso.");
                btnExibir.PerformClick();//botãoexibir
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                AlunosDao alunoBD = new AlunosDao();
                //exclui pelo ID no banco
                Alunos alunoReg = new Alunos(int.Parse(txtID.Text));

                alunoBD.ExcluirAluno(alunoReg);
                MessageBox.Show("Registro excluído com sucesso.");
                btnAlterar.PerformClick();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {//mostrar todos select *
            AlunosDao alunoBD = new Etec.AlunosDao();//instancia da classe AlunosDao
            //limpa os campos textbox do form
            txtID.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtIdade.Text = "";
            txtcaminho.Text = "";
            //passa como parâmetro para o datagridview do form o retorno do getAlunos
            //criado em AlunoDao
            dgvAlunos.DataSource = alunoBD.getAlunos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {//botão sair
            this.Dispose();
            frmMenu abre = new frmMenu();//volta para a tela do menu
            abre.ShowDialog();
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {//BOTÃO LIMPAR
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtID.Text = "";
            txtIdade.Text = "";
            dgvAlunos.DataSource = "";
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {//variável criada para pegar a linha selecionada
            DataGridViewRow LinhaSelecionada;
            //quando clicar num registro no datagridview ele preenche
            //o textbox com o registro
            LinhaSelecionada = dgvAlunos.CurrentRow; //linha selecionada da tabela
            txtID.Text = LinhaSelecionada.Cells[0].Value.ToString();
            txtNome.Text = LinhaSelecionada.Cells[1].Value.ToString();
            txtEndereco.Text = LinhaSelecionada.Cells[2].Value.ToString();
            txtIdade.Text = LinhaSelecionada.Cells[3].Value.ToString();
            //fotoi --> picturebox da foto da tela
            fotoi.Load(LinhaSelecionada.Cells[4].Value.ToString());
            txtcaminho.Text = LinhaSelecionada.Cells[4].Value.ToString();
        }
    }
}
