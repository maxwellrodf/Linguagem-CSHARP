using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //INCLUIR BIBLIOTECA MYSQL

namespace Produto.DAO
{
    public class BaseDAO //CRIA UMA CLASSE BASEDAO EXCLUSIVAMENTE PARA COMUNICAO COM O BANCO DE DADOS 
    {
        public string ConnectionString = "server=localhost; database=produto; uid=root; pwd='';";

        private MySqlConnection conexao { get; set; }

        public MySqlCommand comando { get; set; }

        public MySqlDataAdapter adapter { get; set; }

        public string sql { get; set; }

        public List<MySqlParameter> parametros { get; set; }

        public BaseDAO() //CONSTRUTOR QUE IRÁ SER INICIOALIZADO NA MEMÓRIA TODA VEZ QUE O PROGRAMA FOR INICIADO
        {
            if (conexao == null)
            {
                conexao = new MySqlConnection(ConnectionString);
            }

            comando = new MySqlCommand();
            adapter = new MySqlDataAdapter();
            parametros = new List<MySqlParameter>();
        } 

        public void execute()
        {
            try
            {
                conexao.Open();
                comando = new MySqlCommand(sql, conexao);
                foreach(var item in parametros)
                {
                    comando.Parameters.Add(item);
                }
                comando.ExecuteReader();
            }
            catch(Exception ex)
            {
                throw new Exception("Erro no código:" + ex.Message);
            }
            finally
            {
                conexao.Dispose();
            }
        }

        public MySqlDataReader executeReader()
        {
            try
            {
                comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                return this.comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                conexao.Dispose();
                throw new Exception("Erro no código:" + ex.Message);
            }
        }

        

    }
}
