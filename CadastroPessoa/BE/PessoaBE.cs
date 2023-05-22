using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroPessoa.DAO; //INCLUIR PASTAS/BIBLIOTECA DAO
using CadastroPessoa.VO; //INCLUIR PASTAS/BIBLIOTECA VO


namespace CadastroPessoa.BE
{
    public class PessoaBE
    {
        public FisicaVO pessoa { get; set; }
        private PessoaDAO dao { get; set; }

        public PessoaBE()
        {
            dao = new PessoaDAO();
        }

        public void create()
        {
            dao.pessoaFisica = pessoa;
            dao.create();
        }

        public void update()
        {
            dao.pessoaFisica = pessoa;
            dao.update();
        }

        public void delete()
        {
            dao.pessoaFisica = pessoa;
            dao.delete();
        }

        public List<FisicaVO> list()
        {
            return dao.list();  
        }
    }
}
