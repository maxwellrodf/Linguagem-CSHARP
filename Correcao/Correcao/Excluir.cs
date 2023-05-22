using MySql.Data.MySqlClient;
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
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcluirDoBancoDados(); //FUNCAO PARA EXCLUIR TUPLAS DE ACORDO COM O CRMV CADASTRADO
        }

        private void ExcluirDoBancoDados() //FUNCAO PARA EXCLUIR TUPLAS DE ACORDO COM O CRMV CADASTRADO
        {

            MySqlConnection conexao = new MySqlConnection("server=localhost; uid=root; pwd=''; database=clinica");
            conexao.Open();
            string sql = "DELETE FROM tbl_veterinario WHERE CRMV=?";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("CRMV", txtBoxCRMVExcluir.Text);
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            MessageBox.Show("EXCLUIDO DO BD");

        }

        private void buttonCancelarExcluir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
