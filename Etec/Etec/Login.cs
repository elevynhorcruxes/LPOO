using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec
{
    class Login//classe chamada Login
    {
        //-->para gerar o getters e setters dos atributos
        //botão direito sobre os atributos --> refatorar-->encapsular-->primeiraopção

            //atributos
            private String login;
            private String senha;

        //getters e setters automaticamente
        public String Login1
        {
            get { return login; }
            set { login = value; }
        }

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        //construtores que devem ser criados dentro da classe Login

        //construtor do objeto com valor de parâmetro
        public Login(string login, string senha)
        {
            this.Login1 = login;
            this.Senha = senha;
        }

        public Login()//construtor sem parâmetro
        {

        }
    } 
}
