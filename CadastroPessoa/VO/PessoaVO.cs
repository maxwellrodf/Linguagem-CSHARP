using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa.VO
{
    public class PessoaVO
    {
        public int id { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }   
    }
}
