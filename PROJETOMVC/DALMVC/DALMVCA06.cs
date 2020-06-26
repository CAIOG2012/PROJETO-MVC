using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PROJETOMVCA06.DALMVC
{
    class DALMVCA06
    {

        private MySqlConnection conexao;
        private string string_conexao = "Persist security info = false;" +
                                        "server = localhost; " +
                                        "database = PROJETOMVCA06; " +
                                        "user = root; pwd = ;";

        public void conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch (MySqlException e)
            {
                throw new Exception("Problemas ao conectar com o banco de dados. \nErro " + e.Message);
            }

        }

        public void ExecutarComando(string sql)
        {
            try
            {
                conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possível executar o comando no banco de dados. \nErro " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable executarConsulta(string sql)
        {
            try
            {
                conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possível selecionar os registros no banco de dados. \nErro " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
