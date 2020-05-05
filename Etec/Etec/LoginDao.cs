using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec
{
    class LoginDao
    {//começa aqui **********************************
        string Con;//variável para String de conexão
        Login log = new Login();//chamada da classe Login

        //obtém a string e conexão do arquivo App.config
        public LoginDao()
        {
            //define string de conexão e cria a conexão
            Con = "Persist Security Info=False;server=localhost;" +
                           "database=crudcsharp;uid=root;pwd=";
        }

        public Boolean logar(Login login)
        { //método para verificar se o login e senha existem no banco de dados
            Boolean resp = false;
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();
            //realiza o select no banco de dados
            Com.CommandText = "select login, senha from usuarios WHERE"
                            + " login='" + login.Login1 + "'"
                            + " AND " + "senha='" + login.Senha + "'";

                        try//tenta selecionar e se existir dados ele retorna true
                        {
                            CN.Open();
                            //int registrosAfetados = Com.ExecuteNonQuery();
                            bool verifica = Com.ExecuteReader().HasRows;
                            if (verifica == true)
                            {
                                resp = true;
                            }
                            else
                            {
                                resp = false;
                            }
                        }
                        catch (MySqlException ex)//exceção do banco de dados
                        {
                            resp = false;
                            throw new ApplicationException(ex.ToString());
                            //exceção no sistema
                        }
                        finally
                        {
                             CN.Close();
                         }
                        return resp;
        }

    }
}//termina aqui
