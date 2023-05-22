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
    public partial class Alterar : Form
    {
        public Alterar()
        {
            InitializeComponent();
        }

        private void buttonBuscarAlterar_Click(object sender, EventArgs e)
        {
            panelAlterar.Visible = true; //EXIBE O PAINEL SETADO DE FALSE PARA TRUE QUANDO CLICADO


            //SELECT DO BOTAO BUSCAR PELO PARAMETRO ID
            MySqlConnection conexao = new MySqlConnection("server=localhost; database=clinica; uid=root; pwd=''");
            conexao.Open();

            string sql = "Select nome, formacao, CRMV FROM tbl_veterinario WHERE id=?";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("id", txtAlterarID.Text);
            comando.CommandType = CommandType.Text;

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                txtAlterarNome.Enabled = true;
                comboBoxAlterarFormacao.Enabled = true;
                txtAlterarCRMV.Enabled = true;

                txtAlterarNome.Text = reader[0].ToString();
                comboBoxAlterarFormacao.Text = reader[1].ToString();
                txtAlterarCRMV.Text = reader[2].ToString();
            }
            else
            {
                MessageBox.Show("Nenhum Registro CRMV encontrado");
            }



            //FUNCAO EXIBIR DADOS NO DATAGRID
            ExibirDados();
        }

        private void ExibirDados() //FUNCAO PARA FAZER O SELECT NO DATAGRID E EXIBIR AS COLUNAS
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost; uid=root; pwd=''; database=clinica");
                conexao.Open();
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tbl_veterinario";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);
                adapter.Fill(dt);
                dataGridViewAlterar.DataSource = dt;
            }
            catch
            {
                throw;
            }
        }

        private void buttonCancelarAlterar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonLimparAlterar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost; database=clinica; uid=root; pwd=''");
            conexao.Open();
            string sql = "update tbl_veterinario set nome=?, formacao=?, crmv=? where id=?";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("nome", txtAlterarNome.Text);
            comando.Parameters.AddWithValue("formacao", comboBoxAlterarFormacao.Text);
            comando.Parameters.AddWithValue("crmv", txtAlterarCRMV.Text);
            comando.Parameters.AddWithValue("id", txtAlterarID.Text);

            comando.CommandType = CommandType.Text;
            comando.ExecuteReader();
            MessageBox.Show("ALTERADO NO BD");
            limparTela();
        }

        private void limparTela()
        {
            txtAlterarID.Text = "";
            txtAlterarNome.Text = "";
            comboBoxAlterarFormacao.Text = "";
            txtAlterarCRMV.Text = "";
            dataGridViewAlterar.DataSource = null;
        }
    }
}
