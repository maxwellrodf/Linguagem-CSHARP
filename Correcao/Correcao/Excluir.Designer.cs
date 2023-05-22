namespace Correcao
{
    partial class Excluir
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
            this.txtBoxCRMVExcluir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancelarExcluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxCRMVExcluir
            // 
            this.txtBoxCRMVExcluir.Location = new System.Drawing.Point(228, 121);
            this.txtBoxCRMVExcluir.Name = "txtBoxCRMVExcluir";
            this.txtBoxCRMVExcluir.PlaceholderText = "Digite o CRMV do Veterinário";
            this.txtBoxCRMVExcluir.Size = new System.Drawing.Size(278, 23);
            this.txtBoxCRMVExcluir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "CRMV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "EXCLUIR CADASTRO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonCancelarExcluir
            // 
            this.buttonCancelarExcluir.Location = new System.Drawing.Point(532, 169);
            this.buttonCancelarExcluir.Name = "buttonCancelarExcluir";
            this.buttonCancelarExcluir.Size = new System.Drawing.Size(107, 32);
            this.buttonCancelarExcluir.TabIndex = 3;
            this.buttonCancelarExcluir.Text = "Cancelar";
            this.buttonCancelarExcluir.UseVisualStyleBackColor = true;
            this.buttonCancelarExcluir.Click += new System.EventHandler(this.buttonCancelarExcluir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelarExcluir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCRMVExcluir);
            this.Name = "Excluir";
            this.Text = "Excluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCRMVExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancelarExcluir;
        private System.Windows.Forms.Button button1;
    }
}