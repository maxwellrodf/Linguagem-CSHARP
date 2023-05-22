
namespace Correcao
{
    partial class Consultar
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
            this.txtConsultaNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsultaCRMV = new System.Windows.Forms.TextBox();
            this.txtConsultaFormacao = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsultaNome
            // 
            this.txtConsultaNome.Location = new System.Drawing.Point(96, 26);
            this.txtConsultaNome.Name = "txtConsultaNome";
            this.txtConsultaNome.Size = new System.Drawing.Size(292, 23);
            this.txtConsultaNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONSULTAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtConsultaCRMV
            // 
            this.txtConsultaCRMV.Location = new System.Drawing.Point(221, 98);
            this.txtConsultaCRMV.Name = "txtConsultaCRMV";
            this.txtConsultaCRMV.Size = new System.Drawing.Size(292, 23);
            this.txtConsultaCRMV.TabIndex = 2;
            this.txtConsultaCRMV.TextChanged += new System.EventHandler(this.txtConsultaCRMV_TextChanged);
            // 
            // txtConsultaFormacao
            // 
            this.txtConsultaFormacao.Location = new System.Drawing.Point(96, 73);
            this.txtConsultaFormacao.Name = "txtConsultaFormacao";
            this.txtConsultaFormacao.Size = new System.Drawing.Size(292, 23);
            this.txtConsultaFormacao.TabIndex = 3;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(534, 98);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(98, 26);
            this.buttonPesquisar.TabIndex = 4;
            this.buttonPesquisar.Text = "Buscar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite CRMV";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Formação";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtConsultaFormacao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtConsultaNome);
            this.panel1.Location = new System.Drawing.Point(34, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 273);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(624, 143);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtConsultaCRMV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.label1);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsultaNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsultaCRMV;
        private System.Windows.Forms.TextBox txtConsultaFormacao;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}