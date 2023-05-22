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
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelarConsultar_Click(object sender, EventArgs e)
        {
            Dispose(); //FECHA A TELA QUANDO PRESSIONADO CANCELAR
        }

        private void Consultar_Load(object sender, EventArgs e)
        {

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            panel1.Visible = true; //EXIBE O PAINEL SETADO DE FALSE PARA TRUE QUANDO CLICADO


            //SELECT DO BOTAO BUSCAR
            MySqlConnection conexao = new MySqlConnection("server=localhost; database=clinica; uid=root; pwd=''");
            conexao.Open();

            string sql = "Select nome, formacao FROM tbl_veterinario WHERE CRMV=?";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("crmv", txtConsultaCRMV.Text);
            comando.CommandType = CommandType.Text;

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                txtConsultaNome.Enabled = true;
                txtConsultaFormacao.Enabled = true;
                txtConsultaNome.Text = reader[0].ToString();
                txtConsultaFormacao.Text = reader[1].ToString();
            }
            else
            {
                MessageBox.Show("Nenhum Registro CRMV encontrado");
            }



            //FUNCAO EXIBIR DADOS NO DATAGRID
            ExibirDados();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpaTelaConsulta(); //LIMPA A TELA DA CONSULTA E DO DATAGRID
        }

        private void limpaTelaConsulta() //LIMPA A TELA DA CONSULTA E DO DATAGRID
        {
            txtConsultaNome.Text = "";
            txtConsultaFormacao.Text = "";
            txtConsultaCRMV.Text = "";
      
            dataGridView1.DataSource = null; //LIMPA A CONSULTA DO DATAGRIDVIEW




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose(); //FECHA A TELA QUANDO PRESSIONADO CANCELAR NA CONSULTA
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
                dataGridView1.DataSource = dt;
            }
            catch
            {
                throw;
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            
        }

        private void txtConsultaCRMV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
