using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVA_FABIO_CODO.VO;
using AVA_FABIO_CODO.DAO;


namespace AVA_FABIO_CODO.BE
{
    public class ClienteBE
    {
        public Cliente cliente { get; set; }
        private ClienteDAO dao { get; set; }

        public ClienteBE()
        {
            dao = new ClienteDAO();
        }

        public void create()
        {
            dao.cliente = cliente;
            dao.create();
        }
        public void update()
        {
            dao.cliente = cliente;
            dao.update();
        }
        public void delete()
        {
            dao.cliente = cliente;
            dao.delete();
        }
        public List<Cliente> list()
        {
            return dao.list(); ;
        }
    }
}
