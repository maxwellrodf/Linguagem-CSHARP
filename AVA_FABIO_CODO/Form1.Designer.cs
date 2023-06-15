namespace AVA_FABIO_CODO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtID = new TextBox();
            cmbCliente = new ComboBox();
            cmbProduto = new ComboBox();
            txtQuantidade = new TextBox();
            listBoxCarregarLista = new ListBox();
            buttonCancelar = new Button();
            buttonIncluir = new Button();
            buttonAlterar = new Button();
            buttonSelecionar = new Button();
            buttonExcluir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(128, 53);
            txtID.Name = "txtID";
            txtID.Size = new Size(496, 23);
            txtID.TabIndex = 0;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(128, 97);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(496, 23);
            cmbCliente.TabIndex = 1;
            // 
            // cmbProduto
            // 
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(128, 143);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(496, 23);
            cmbProduto.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(128, 189);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(496, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // listBoxCarregarLista
            // 
            listBoxCarregarLista.FormattingEnabled = true;
            listBoxCarregarLista.ItemHeight = 15;
            listBoxCarregarLista.Location = new Point(693, 27);
            listBoxCarregarLista.Name = "listBoxCarregarLista";
            listBoxCarregarLista.Size = new Size(368, 229);
            listBoxCarregarLista.TabIndex = 4;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(128, 274);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(155, 38);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonIncluir
            // 
            buttonIncluir.Location = new Point(315, 274);
            buttonIncluir.Name = "buttonIncluir";
            buttonIncluir.Size = new Size(155, 38);
            buttonIncluir.TabIndex = 6;
            buttonIncluir.Text = "Incluir";
            buttonIncluir.UseVisualStyleBackColor = true;
            buttonIncluir.Click += buttonIncluir_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(503, 274);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(155, 38);
            buttonAlterar.TabIndex = 7;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Location = new Point(906, 274);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(155, 38);
            buttonSelecionar.TabIndex = 8;
            buttonSelecionar.Text = "Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(906, 330);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(155, 38);
            buttonExcluir.TabIndex = 9;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 61);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 10;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 105);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 11;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 151);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 12;
            label3.Text = "Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 197);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 13;
            label4.Text = "Quantidade";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 411);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonSelecionar);
            Controls.Add(buttonAlterar);
            Controls.Add(buttonIncluir);
            Controls.Add(buttonCancelar);
            Controls.Add(listBoxCarregarLista);
            Controls.Add(txtQuantidade);
            Controls.Add(cmbProduto);
            Controls.Add(cmbCliente);
            Controls.Add(txtID);
            Name = "Form1";
            Text = "AVALIACAO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private ComboBox cmbCliente;
        private ComboBox cmbProduto;
        private TextBox txtQuantidade;
        private ListBox listBoxCarregarLista;
        private Button buttonCancelar;
        private Button buttonIncluir;
        private Button buttonAlterar;
        private Button buttonSelecionar;
        private Button buttonExcluir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}