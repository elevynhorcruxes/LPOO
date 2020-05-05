using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec
{
    class Alunos
    {
        //-->para gerar o getters e setters dos atributos
        //botão direito sobre os atributos -->
        //refatorar-->encapsular-->primeiraopção
        //atributos da classe Alunos

        private int _alunoID;
        private String _nome;
        private String _email;
        private int _idade;
        private String _foto;

        public int AlunoID
        {
            get
            { return _alunoID; }
            set
            { _alunoID = value; }
        }

        public String Nome
        {
            get
            { return _nome; }
            set
            { _nome = value; }
        }

        public String Email
        {
            get
            { return _email; }
            set
            { _email = value; }
        }

        public int Idade
        {
            get
            { return _idade; }
            set
            { _idade = value; }
        }

        public String Foto
        {
            get
            { return _foto; }
            set
            { _foto = value; }
        }

        //costrutor do objeto sem valor de parâmetro
        public Alunos()
        {

        }

        //construtor do objeto com valor de parâmetro id
        public Alunos(int ID)
        {
            this.AlunoID = ID;
        }

        //construtor do objeto com valor de parâmetro nome, endereço, idade
        public Alunos(string nome, string email, int idade, string foto)
        {
            this.Nome = nome;
            this.Email = email;
            this.Idade = idade;
            this.Foto = foto;
        }

        //construtor do objeto com valor de parametro id, nome, endereco, idade
        public Alunos(int ID, string nome, string email, int idade, String foto)
        {
            this.AlunoID = ID;
            this.Nome = nome;
            this.Email = email;
            this.Idade = idade;
            this.Foto = foto;
        }
    }
}
    