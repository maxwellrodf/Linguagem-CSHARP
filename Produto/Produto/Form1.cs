namespace Produto
{
    public partial class CadastroProduto : Form
    {
        private BE.ProdutoBE be { get; set; }
        private VO.Categoria produtoCategoria { get; set; }
        
        
        public CadastroProduto()
        {
            InitializeComponent();
            ativarAlteracao(false);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            carregarTela(); 
            be = new BE.ProdutoBE();
            be.produto = produtoCategoria;
            be.create();
            carregar();
            limparTela();
            MessageBox.Show("CADASTRADO NO BD");
            
           
        }

        private void ativarAlteracao(bool ativar)
        {
            buttonIncluir.Enabled = !ativar;
            buttonAlterar.Enabled = ativar;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            limparTela();
            ativarAlteracao(false);
        }

        private void limparTela()
        {
            textBoxCodigo.Text = "";
            textBoxNome.Text = "";
            textBoxDescricao.Text = "";
        }

        private void carregar() //ENVIA PARA TEXTBOX
        {
            BE.ProdutoBE be = new BE.ProdutoBE();
            listBoxLista.DataSource = null;
            listBoxLista.DataSource = be.list();
            listBoxLista.ValueMember = "codigo";
            listBoxLista.DisplayMember = "nome";
            listBoxLista.Refresh();
        }

        private void carregarTela() 
        {
            produtoCategoria = new VO.Categoria();
            produtoCategoria.codigo = int.Parse(textBoxCodigo.Text);
            produtoCategoria.nome = textBoxNome.Text;
            produtoCategoria.descricao = textBoxDescricao.Text;
        }

        private void buttonAlterar_Click(object sender, EventArgs e) 
        {
            carregarTela();
            be = new BE.ProdutoBE();
            be.produto = produtoCategoria;
            be.update();
            carregar();
            limparTela();
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            limparTela();
            produtoCategoria = (VO.Categoria)(listBoxLista.SelectedItem);
            receberTela();
            ativarAlteracao(true);
        }

        private void receberTela()
        {
            textBoxCodigo.Text = produtoCategoria.codigo.ToString();
            textBoxNome.Text = produtoCategoria.nome;
            textBoxDescricao.Text = produtoCategoria.descricao;

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            be = new BE.ProdutoBE();
            be.produto = (VO.Categoria)(listBoxLista.SelectedItem);
            receberTela();
            be.delete();
            carregar();
            limparTela();
        }
    }
}