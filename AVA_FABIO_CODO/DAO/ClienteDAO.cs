using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVA_FABIO_CODO.VO;
using MySql.Data.MySqlClient;

namespace AVA_FABIO_CODO.DAO
{
    public class ClienteDAO:BaseDAO
    {
        public static List<Cliente> listaCliente;

        public Cliente cliente { get; set; }

        public ClienteDAO()
        {
            if (listaCliente == null)
            {
                listaCliente = new List<Cliente>();
            }
        }

        public void create()
        {
            this.sql = "insert into cliente(nome, quantidade, id_produto) values (@nome, @quantidade, @produto)";
            cmd.CommandText = this.sql;
            this.parametros.Add(new MySqlParameter("@nome", cliente.nome));
            this.parametros.Add(new MySqlParameter("@quantidade", cliente.quantidade));
            this.parametros.Add(new MySqlParameter("@produto", cliente.produto.id));
            execute();
        }

        public void update()
        {
            this.sql = "update cliente set nome=@nome, quantidade=@quantidade, id_produto=@produto where id=@id";
            cmd.CommandText = this.sql;
            parametros.Add(new MySqlParameter("@nome", cliente.nome));
            parametros.Add(new MySqlParameter("@quantidade", cliente.quantidade));
            parametros.Add(new MySqlParameter("@produto", cliente.produto.id));
            parametros.Add(new MySqlParameter("@id", cliente.id));
            execute();
        }

        public void delete()
        {
            this.sql = "delete from cliente where id=@id";
            cmd.CommandText = this.sql;
            parametros.Add(new MySqlParameter("@id", cliente.id));
            execute();
        }

        public List<Cliente> list() 
        {
            this.sql = "select * from cliente";
            listaCliente = new List<Cliente>();

            using (var dr = executeReader())
            {
                while (dr.Read())
                {
                    cliente = new Cliente();
                    cliente.id = Convert.ToInt32(dr["id"]);
                    cliente.nome = dr["nome"] != DBNull.Value ? dr["nome"].ToString() : "";
                    cliente.quantidade = dr["quantidade"] != DBNull.Value ? dr["quantidade"].ToString() : "";
                    
                    cliente.produto = new Produto();
                    cliente.produto.id = Convert.ToInt32(dr["id"]);
                    listaCliente.Add(cliente);
                }
            }
            return listaCliente;
        }
    }
}
