using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVA_FABIO_CODO.VO
{
    public class Cliente
    {
        public int id {  get; set; }    
        public string nome { get; set; }
        public string quantidade { get; set; }

        public Produto produto { get; set; }

    }
}
