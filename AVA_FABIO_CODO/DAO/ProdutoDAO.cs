using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVA_FABIO_CODO.VO;

namespace AVA_FABIO_CODO.DAO
{
    public class ProdutoDAO : BaseDAO
    {
        public List<Produto> listaProduto;
        public Produto produto { get; set; }

        public List<Produto> list()
        {
            listaProduto = new List<Produto>();
            this.sql = "select * from produto"; 
            using (var dr = executeReader())
            {
                while (dr.Read())
                {
                    produto = new Produto();
                    produto.id = Convert.ToInt32(dr["id"]);
                    produto.descricao = dr["descricao"] != DBNull.Value ? dr["descricao"].ToString() : "";
                    listaProduto.Add(produto);
                }
            }
            return listaProduto;
        }
    }
}
