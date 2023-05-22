using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Correcao
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

            MySqlConnection conexao = new MySqlConnection("server=localhost; database=clinica; uid=root; pwd=''");
            conexao.Open();

            MySqlCommand cmd = new MySqlCommand("Insert into tbl_veterinario (nome, CRMV, formacao) values ("+
                "'"+txtNome.Text+"','"
                +txtCRMV.Text+"','"
                +txtFormacao.Text+"')", conexao);

            cmd.ExecuteReader();
            MessageBox.Show("CADASTRADO NO BD");
            this.Hide();
        }
    }
}
