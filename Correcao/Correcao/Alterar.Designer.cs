namespace Correcao
{
    partial class Alterar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAlterar = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlterarCRMV = new System.Windows.Forms.TextBox();
            this.comboBoxAlterarFormacao = new System.Windows.Forms.ComboBox();
            this.buttonCancelarAlterar = new System.Windows.Forms.Button();
            this.buttonLimparAlterar = new System.Windows.Forms.Button();
            this.dataGridViewAlterar = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlterarNome = new System.Windows.Forms.TextBox();
            this.txtAlterarID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBuscarAlterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlterar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAlterar
            // 
            this.panelAlterar.Controls.Add(this.label5);
            this.panelAlterar.Controls.Add(this.txtAlterarCRMV);
            this.panelAlterar.Controls.Add(this.comboBoxAlterarFormacao);
            this.panelAlterar.Controls.Add(this.buttonCancelarAlterar);
            this.panelAlterar.Controls.Add(this.buttonLimparAlterar);
            this.panelAlterar.Controls.Add(this.dataGridViewAlterar);
            this.panelAlterar.Controls.Add(this.label4);
            this.panelAlterar.Controls.Add(this.label3);
            this.panelAlterar.Controls.Add(this.txtAlterarNome);
            this.panelAlterar.Location = new System.Drawing.Point(78, 151);
            this.panelAlterar.Name = "panelAlterar";
            this.panelAlterar.Size = new System.Drawing.Size(645, 327);
            this.panelAlterar.TabIndex = 13;
            this.panelAlterar.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "CRMV";
            // 
            // txtAlterarCRMV
            // 
            this.txtAlterarCRMV.Location = new System.Drawing.Point(96, 119);
            this.txtAlterarCRMV.Name = "txtAlterarCRMV";
            this.txtAlterarCRMV.Size = new System.Drawing.Size(292, 23);
            this.txtAlterarCRMV.TabIndex = 12;
            // 
            // comboBoxAlterarFormacao
            // 
            this.comboBoxAlterarFormacao.FormattingEnabled = true;
            this.comboBoxAlterarFormacao.Items.AddRange(new object[] {
            "ESPECIALISTA",
            "GERAL",
            "ESTAGIÁRIO"});
            this.comboBoxAlterarFormacao.Location = new System.Drawing.Point(96, 73);
            this.comboBoxAlterarFormacao.Name = "comboBoxAlterarFormacao";
            this.comboBoxAlterarFormacao.Size = new System.Drawing.Size(292, 23);
            this.comboBoxAlterarFormacao.TabIndex = 11;
            this.comboBoxAlterarFormacao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonCancelarAlterar
            // 
            this.buttonCancelarAlterar.Location = new System.Drawing.Point(500, 67);
            this.buttonCancelarAlterar.Name = "buttonCancelarAlterar";
            this.buttonCancelarAlterar.Size = new System.Drawing.Size(98, 32);
            this.buttonCancelarAlterar.TabIndex = 10;
            this.buttonCancelarAlterar.Text = "Cancelar";
            this.buttonCancelarAlterar.UseVisualStyleBackColor = true;
            this.buttonCancelarAlterar.Click += new System.EventHandler(this.buttonCancelarAlterar_Click);
            // 
            // buttonLimparAlterar
            // 
            this.buttonLimparAlterar.Location = new System.Drawing.Point(500, 20);
            this.buttonLimparAlterar.Name = "buttonLimparAlterar";
            this.buttonLimparAlterar.Size = new System.Drawing.Size(98, 32);
            this.buttonLimparAlterar.TabIndex = 9;
            this.buttonLimparAlterar.Text = "Alterar";
            this.buttonLimparAlterar.UseVisualStyleBackColor = true;
            this.buttonLimparAlterar.Click += new System.EventHandler(this.buttonLimparAlterar_Click);
            // 
            // dataGridViewAlterar
            // 
            this.dataGridViewAlterar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlterar.Location = new System.Drawing.Point(10, 170);
            this.dataGridViewAlterar.Name = "dataGridViewAlterar";
            this.dataGridViewAlterar.RowTemplate.Height = 25;
            this.dataGridViewAlterar.Size = new System.Drawing.Size(624, 143);
            this.dataGridViewAlterar.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Formação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome";
            // 
            // txtAlterarNome
            // 
            this.txtAlterarNome.Location = new System.Drawing.Point(96, 26);
            this.txtAlterarNome.Name = "txtAlterarNome";
            this.txtAlterarNome.Size = new System.Drawing.Size(292, 23);
            this.txtAlterarNome.TabIndex = 0;
            // 
            // txtAlterarID
            // 
            this.txtAlterarID.Location = new System.Drawing.Point(265, 79);
            this.txtAlterarID.Name = "txtAlterarID";
            this.txtAlterarID.Size = new System.Drawing.Size(292, 23);
            this.txtAlterarID.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Digite ID";
            // 
            // buttonBuscarAlterar
            // 
            this.buttonBuscarAlterar.Location = new System.Drawing.Point(578, 79);
            this.buttonBuscarAlterar.Name = "buttonBuscarAlterar";
            this.buttonBuscarAlterar.Size = new System.Drawing.Size(98, 26);
            this.buttonBuscarAlterar.TabIndex = 11;
            this.buttonBuscarAlterar.Text = "Buscar";
            this.buttonBuscarAlterar.UseVisualStyleBackColor = true;
            this.buttonBuscarAlterar.Click += new System.EventHandler(this.buttonBuscarAlterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "ALTERAR";
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.panelAlterar);
            this.Controls.Add(this.txtAlterarID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBuscarAlterar);
            this.Controls.Add(this.label1);
            this.Name = "Alterar";
            this.Text = "Alterar";
            this.panelAlterar.ResumeLayout(false);
            this.panelAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlterar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAlterar;
        private System.Windows.Forms.Button buttonCancelarAlterar;
        private System.Windows.Forms.Button buttonLimparAlterar;
        private System.Windows.Forms.DataGridView dataGridViewAlterar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlterarNome;
        private System.Windows.Forms.TextBox txtAlterarID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuscarAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAlterarFormacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlterarCRMV;
    }
}