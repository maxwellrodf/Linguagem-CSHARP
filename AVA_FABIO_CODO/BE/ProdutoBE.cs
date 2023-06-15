using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVA_FABIO_CODO.VO;
using AVA_FABIO_CODO.DAO;

namespace AVA_FABIO_CODO.BE
{
    public class ProdutoBE
    {
        public Produto produto { get; set; }
        private ProdutoDAO dao { get; set; }
        public ProdutoBE()
        {
            dao = new ProdutoDAO();
        }

        public List<Produto> list()
        {
            return dao.list();
        }
    }
}
