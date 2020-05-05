using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec
{
    class Disciplina
    {
        //-->para gerar o getters e settersdos atributos
        //botão direito sobre os atributos --> refatorar-->encapsular-->primeiraopção

        private int _coddisc;
        public int Coddisc
        {
            get
            { return _coddisc; }
            set
            { _coddisc = value; }
        }

        private String _nomedisc;
        public String Nomedisc
        {
            get
            { return _nomedisc; }
            set
            { _nomedisc = value; }
        }

        private int _codaluno;
        public int Codaluno
        {
            get
            { return _codaluno; }
            set
            { _codaluno = value; }
        }

        private String _mencao;
        public String Mencao
        {
            get
            { return _mencao; }
            set
            { _mencao = value; }
        }

        public Disciplina()
        {

        }

        public Disciplina(int coddisc)
        {
            Coddisc = coddisc;
        }

        public Disciplina(string nomedisc, int codaluno, string mencao)
        {
            Nomedisc = nomedisc;
            Codaluno = codaluno;
            Mencao = mencao;
        }

        public Disciplina(int coddisc, string nomedisc, int codaluno, string mencao)
        {
            Coddisc = coddisc;
            Nomedisc = nomedisc;
            Codaluno = codaluno;
            Mencao = mencao;
        }
    }
}
