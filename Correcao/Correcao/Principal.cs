using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correcao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void veterinárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro(); 
            cad.Show(); //CHAMA FORMULARIO CADASTRO
        }

        private void veterinárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar(); 
            consultar.Show(); //CHAMA FORMULARIO CONSULTAR
        }

        private void veterinárioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Excluir excluir = new Excluir();
            excluir.Show(); //CHAMA FORMULARIO EXCLUIR
        }

        private void veterinárioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Alterar alterar = new Alterar();
            alterar.Show(); //CHAMA FORMULARIO ALTERAR
        }
    }
}
