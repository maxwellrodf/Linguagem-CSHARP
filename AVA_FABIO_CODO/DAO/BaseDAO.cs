using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVA_FABIO_CODO.DAO
{
    public class BaseDAO
    {
        public string ConnectionString = "server=localhost; database=vendas; uid=root; pwd='';";

        private MySqlConnection cn { get; set; } //ATRIBUTOS DA CLASSE 

        public MySqlCommand cmd { get; set; } //ATRIBUTOS DA CLASSE 

        public MySqlDataAdapter adapter { get; set; } //ATRIBUTOS DA CLASSE 

        public string sql { get; set; } //ATRIBUTOS DA CLASSE 

        public List<MySqlParameter> parametros { get; set; }

        public BaseDAO() //CONSTRUTOR QUE IRÁ SER INICIALIZADO NA MEMÓRIA TODA VEZ QUE O PROGRAMA FOR INICIADO
        {
            if (cn == null)
            {
                cn = new MySqlConnection(ConnectionString);
            }

            cmd = new MySqlCommand();
            adapter = new MySqlDataAdapter();
            parametros = new List<MySqlParameter>();
        }
        public void execute()
        {
            try
            {
                cn.Open();
                cmd = new MySqlCommand(sql, cn);
                foreach (var item in parametros)
                {
                    cmd.Parameters.Add(item);
                }
                cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw new Exception("ERRO no código:" + ex.Message);

            }
            finally
            {
                cn.Dispose();
            }
        }

        public MySqlDataReader executeReader()
        {
            try
            {
                cmd = new MySqlCommand(sql, cn);
                cn.Open();
                return this.cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                cn.Dispose();
                throw new Exception("Erro no Código: " + ex.Message);
            }
        }
    }
}
