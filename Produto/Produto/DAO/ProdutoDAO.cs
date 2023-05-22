using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Produto.VO;

namespace Produto.DAO
{
    class ProdutoDAO : BaseDAO
    {
        public static List<Categoria> listaProdutos;
        public Categoria produtoCategoria { get; set; }

        public ProdutoDAO()
        {
            if(listaProdutos == null)
            {
                listaProdutos = new List<Categoria>();
            }
        }
        
        public void create()
        {   
            this.sql = "insert into categoria (nome, descricao) values (@nome, @descricao)";
            comando.CommandText = this.sql;
            this.parametros.Add(new MySqlParameter("@nome", produtoCategoria.nome));
            this.parametros.Add(new MySqlParameter("@descricao", produtoCategoria.descricao));
            execute();
        }

        public void update()
        {
            this.sql = "update categoria set nome=@nome, descricao=@descricao where codigo=@codigo";
            comando.CommandText = this.sql;
            parametros.Add(new MySqlParameter("@codigo", produtoCategoria.codigo));
            parametros.Add(new MySqlParameter("@nome", produtoCategoria.nome));
            parametros.Add(new MySqlParameter("descricao", produtoCategoria.descricao));
            execute();
            
        }

        public void delete()
        {
            this.sql = "delete from categoria where codigo=@codigo";
            comando.CommandText = this.sql;
            parametros.Add(new MySqlParameter("@codigo", produtoCategoria.codigo));
            execute();
        }

        public List<Categoria> list()
        {
            this.sql = "select * from categoria";
            listaProdutos = new List<Categoria>();

            using (var dr = executeReader())
            {
                while (dr.Read())
                {
                    produtoCategoria = new Categoria();
                    produtoCategoria.codigo = Convert.ToInt32(dr["codigo"]);
                    produtoCategoria.nome = dr["nome"] != DBNull.Value ? dr["nome"].ToString() : "";
                    produtoCategoria.descricao = dr["descricao"] != DBNull.Value ? dr["nome"].ToString() : "";

                    listaProdutos.Add(produtoCategoria);
                }
            }
            return listaProdutos;
        }
        

       

        

    }
}
