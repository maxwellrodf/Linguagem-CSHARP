using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Produto.DAO;
using Produto.VO; //INCLUIR BIBLIOTECAS DAO E VO

namespace Produto.BE
{
    public class ProdutoBE
    {
        public Categoria produto { get; set; }  

        private ProdutoDAO dao { get; set; }

        public ProdutoBE()
        {
            dao = new ProdutoDAO(); 
        }

        public void create()
        {
            dao.produtoCategoria = produto;
            dao.create();

        }

        public void update()
        {
            dao.produtoCategoria = produto;
            dao.update();
        }

        public void delete()
        {
            dao.produtoCategoria = produto;
            dao.delete();
        }

        public List<Categoria> list()
        {
            return dao.list();   
        }
        
    }
}
