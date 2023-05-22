using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql; //INCLUIR BIBLIOTECA POSTGRES

namespace CadastroPessoa.DAO
{
    public class BaseDAO //INTEGRACAO PARA INTEGRACAO COM O BANCO DE DADOS POSTGRES
    {
        public string ConnectionString = "server=localhost; database=cadastro; port=5432; user id=postgres; password='!qazx2wsxc';";

        private NpgsqlConnection conexao { get; set; }

        public NpgsqlCommand comando { get; set; }

        public NpgsqlDataAdapter adapter { get; set; }

        public string sql { get; set; }

        public List<NpgsqlParameter> parametros { get; set; }

        public BaseDAO() //CONSTRUTOR
        {
            if(conexao == null)
            {
                conexao = new NpgsqlConnection(ConnectionString);   
            }

            comando = new NpgsqlCommand();
            adapter = new NpgsqlDataAdapter();
            parametros = new List<NpgsqlParameter>();
        }

        public void execute()
        {
            try
            {
                conexao.Open();
                comando = new NpgsqlCommand(sql, conexao);
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

        public NpgsqlDataReader executeReader()
        {
            try
            {
                comando = new NpgsqlCommand(sql, conexao);
                conexao.Open();
                return this.comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                conexao.Dispose();
                throw new Exception ("Erro no código:" + ex.Message);
            }
        }
    }
}
