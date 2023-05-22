namespace CadastroPessoa
{
    public partial class Form1 : Form
    {
        private BE.PessoaBE be { get; set; }
        private VO.FisicaVO pessoaFisica { get; set; }

        public Form1()
        {
            InitializeComponent();
            ativarAlteracao(false);
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            carregarTela();
            be = new BE.PessoaBE();
            be.pessoa = pessoaFisica;
            be.create();
            carregar();
            limparTela();
            MessageBox.Show("CADASTRADO NO BD");
        }

        private void carregarTela()
        {
            pessoaFisica = new VO.FisicaVO();
            pessoaFisica.id = int.Parse(textBoxID.Text);
            pessoaFisica.cpf = textBoxCPF.Text;
            pessoaFisica.nome = textBoxNome.Text;
            pessoaFisica.endereco = textBoxEnd.Text;
            pessoaFisica.telefone = textBoxTelefone.Text;
        }

        private void carregar() //ENVIA PARA TEXTBOX
        {
            BE.PessoaBE be = new BE.PessoaBE();
            listBoxLista.DataSource = null;
            listBoxLista.DataSource = be.list();
            listBoxLista.ValueMember = "id";
            listBoxLista.DisplayMember = "nome";
            listBoxLista.Refresh();
        }

        private void limparTela()
        {
            textBoxID.Text = "";
            textBoxCPF.Text = "";
            textBoxNome.Text = "";
            textBoxEnd.Text = "";
            textBoxTelefone.Text = "";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            limparTela();
            ativarAlteracao(false);
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            carregarTela();
            be = new BE.PessoaBE();
            be.pessoa = pessoaFisica;
            be.update();
            carregar();
            limparTela();
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            limparTela();
            pessoaFisica = (VO.FisicaVO)(listBoxLista.SelectedItem);
            receberTela();
            ativarAlteracao(true);
        }

        private void receberTela()
        {
            textBoxID.Text = pessoaFisica.id.ToString();
            textBoxCPF.Text = pessoaFisica.cpf;
            textBoxNome.Text = pessoaFisica.nome;
            textBoxEnd.Text = pessoaFisica.endereco;
            textBoxTelefone.Text = pessoaFisica.telefone;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            be = new BE.PessoaBE();
            be.pessoa = (VO.FisicaVO)(listBoxLista.SelectedItem);
            receberTela();
            be.delete();
            carregar();
            limparTela();
        }

        private void ativarAlteracao(bool ativar)
        {
            buttonIncluir.Enabled = !ativar;
            buttonAlterar.Enabled = ativar;
        }
    }
}