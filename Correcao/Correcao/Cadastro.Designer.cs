
namespace Correcao
{
    partial class Cadastro
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCRMV = new System.Windows.Forms.TextBox();
            this.txtFormacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "CRMV";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(205, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(291, 23);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCRMV
            // 
            this.txtCRMV.Location = new System.Drawing.Point(205, 130);
            this.txtCRMV.Name = "txtCRMV";
            this.txtCRMV.Size = new System.Drawing.Size(291, 23);
            this.txtCRMV.TabIndex = 4;
            // 
            // txtFormacao
            // 
            this.txtFormacao.FormattingEnabled = true;
            this.txtFormacao.Items.AddRange(new object[] {
            "ESPECIALISTA",
            "GERAL",
            "ESTAGIÁRIO"});
            this.txtFormacao.Location = new System.Drawing.Point(205, 182);
            this.txtFormacao.Name = "txtFormacao";
            this.txtFormacao.Size = new System.Drawing.Size(291, 23);
            this.txtFormacao.TabIndex = 5;
            this.txtFormacao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Formação";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(134, 244);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(152, 33);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(353, 244);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(143, 33);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "CADASTRO";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 349);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFormacao);
            this.Controls.Add(this.txtCRMV);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCRMV;
        private System.Windows.Forms.ComboBox txtFormacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label4;
    }
}