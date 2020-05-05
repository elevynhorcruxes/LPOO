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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try//botão logar
            {
                LoginDao loginBD = new LoginDao();//instanciar a classe

                Login loginReg = new Login(txtLogin.Text, txtSenha.Text);//instanciar a classe

                if (loginBD.logar(loginReg))//se o resultado do método chamado for true
                {
                    frmMenu abre = new frmMenu();//ABRE O FORMULARIO FORM1

                    this.Hide();//fecha a tela ativa
                    if (abre == null)//se a tela de menu já não estiver aberta
                    {
                        abre = new frmMenu();
                        this.Hide();
                    }
                    else//senão abre a tela menu
                    {
                        abre.Show();
                        this.Hide();
                    }
                    abre.Show();
                }
                else
                {
                    MessageBox.Show("Login e Senha Inválidos!");
                    txtLogin.Focus();
                } 
            }

            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }//fecha a ação clique do botão
    }
}