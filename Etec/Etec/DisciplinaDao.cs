using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec
{
    class DisciplinaDao
    {
        String Con;
        Disciplina disc = new Disciplina();
        Alunos alu = new Alunos();

        //obtem a string e conexão do arquivo App.config
        public DisciplinaDao()
        {
            //define string de conexão e cria a conexão

            Con = "Persist Security Info=False;server=localhost;database=crudcsharp;uid=root;pwd=";
        }

        //inclui uma nova disciplina na tabela
        public void IncluirDisciplina(Disciplina disciplina)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "INSERT INTO Disciplina(nomedisc, codaluno, mencao) " +
                                   "Values(?nomedisc,?codaluno,?mencao)";

            Com.Parameters.AddWithValue("?nomedisc", disciplina.Nomedisc);
            Com.Parameters.AddWithValue("?codaluno", disciplina.Codaluno);
            Com.Parameters.AddWithValue("?mancao", disciplina.Mencao);

            try
            {
                CN.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }

        //altera uma disciplina na tabela
        public void AlterarDisciplina(Disciplina disciplina)
        {//método alterar disciplina
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "UPDATE Disciplina SET nomedisc= '" + disciplina.Nomedisc + "'" + "," + " codaluno='"
                               + disciplina.Codaluno + "'" + "," + " mencao='" + disciplina.Mencao
                               + "' WHERE" + " Coddisc=" + disciplina.Coddisc;

            try
            {
                CN.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }
        
        //exclui uma disciplina na tabela
        public void ExcluirDisciplina(Disciplina disciplina)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "DELETE FROM alunos WHERE" + " coddisc=" + disciplina.Coddisc;

            try
            {
                CN.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }

        //obtém todas as diciplinas selecionado
        public DataTable getDisciplina()
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand cmd = CN.CreateCommand();
            MySqlDataAdapter da;

            //cmd.CommandText = "SELECT * from disciplina";
            cmd.CommandText = "SELECT d.Coddisc, d.Nomedisc, d.Codaluno, a.Nome, d.Mencao FROM disciplina d, alunos a WHERE d.codaluno = a.id";
            try
            {
                CN.Open();
                cmd = new MySqlCommand(cmd.CommandText, CN);
                da = new MySqlDataAdapter(cmd);
                //
                DataTable dtDisciplina = new DataTable();
                da.Fill(dtDisciplina);
                return dtDisciplina;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }
    }
}
