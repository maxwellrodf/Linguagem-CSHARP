namespace AVA_FABIO_CODO
{
    public partial class Form1 : Form
    {
        private BE.ClienteBE be { get; set; }
        private BE.ProdutoBE produtoBE { get; set; }
        private VO.Cliente cliente { get; set; }
        private VO.Produto produto { get; set; }

        public Form1()
        {
            InitializeComponent();
            carregar();
            ativarAlteracao(false);
            carregarProduto();
            carregarCliente();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            limparTela();
            ativarAlteracao(false);
        }

        private void limparTela()
        {
            txtID.Text = "";
            cmbCliente.Text = "";
            cmbProduto.Text = "";
            txtQuantidade.Text = "";
        }

        private void carregarTela()
        {   //VARIAVEIS RECEBEM DADOS DO TEXTBOX
            cliente = new VO.Cliente();
            cliente.id = int.Parse(txtID.Text);
            cliente.nome = cmbCliente.Text;
            cliente.quantidade = txtQuantidade.Text;
            cliente.produto = (VO.Produto)cmbProduto.SelectedItem;
        }

        private void carregar() //CARREGAR PARA O LISTBOX
        {
            BE.ClienteBE be = new BE.ClienteBE();
            listBoxCarregarLista.DataSource = null;
            listBoxCarregarLista.DataSource = be.list();
            listBoxCarregarLista.ValueMember = "id";
            listBoxCarregarLista.DisplayMember = "nome";
            listBoxCarregarLista.Refresh();

        }

        private void carregarProduto()
        {
            BE.ProdutoBE be = new BE.ProdutoBE();
            cmbProduto.DataSource = null;
            cmbProduto.DataSource = be.list();
            cmbProduto.ValueMember = "id";
            cmbProduto.DisplayMember = "descricao";
            cmbProduto.Refresh();
        }

        private void carregarCliente()
        {
            BE.ClienteBE be = new BE.ClienteBE();
            cmbCliente.DataSource = null;
            cmbCliente.DataSource = be.list();
            cmbCliente.ValueMember = "id";
            cmbCliente.DisplayMember = "nome";
            cmbCliente.Refresh();
        }



        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            carregarTela();
            be = new BE.ClienteBE();
            be.cliente = cliente;
            be.create();
            carregar();
            limparTela();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            carregarTela();
            be = new BE.ClienteBE();
            be.cliente = cliente;
            be.update();
            carregar();
            limparTela();
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            limparTela();
            cliente = (VO.Cliente)(listBoxCarregarLista.SelectedItem);
            receberTela();
            ativarAlteracao(true);
        }

        private void receberTela()
        {
            txtID.Text = cliente?.id.ToString();
            txtQuantidade.Text = cliente?.quantidade;
            cmbCliente.Text = cliente.nome;

            for (int i = 0; i < cmbProduto.Items.Count; i++)
            {
                if (((VO.Produto)cmbProduto.Items[i]).id == cliente.produto.id)
                {
                    cmbProduto.SelectedIndex = i;
                    return;
                }
            }

            for (int i = 0; i < cmbProduto.Items.Count; i++)
            {
                if (((VO.Cliente)cmbCliente.Items[i]).id == cliente.id)
                {
                    cmbProduto.SelectedIndex = i;
                    return;
                }
            }










        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            be = new BE.ClienteBE();
            be.cliente = (VO.Cliente)(listBoxCarregarLista.SelectedItem);
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