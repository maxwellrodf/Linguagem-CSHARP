
namespace Correcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinárioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinárioToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.alterarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veterinárioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastrar";
            // 
            // veterinárioToolStripMenuItem
            // 
            this.veterinárioToolStripMenuItem.Name = "veterinárioToolStripMenuItem";
            this.veterinárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veterinárioToolStripMenuItem.Text = "Veterinário";
            this.veterinárioToolStripMenuItem.Click += new System.EventHandler(this.veterinárioToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veterinárioToolStripMenuItem1});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultaToolStripMenuItem.Text = "Consultar";
            // 
            // veterinárioToolStripMenuItem1
            // 
            this.veterinárioToolStripMenuItem1.Name = "veterinárioToolStripMenuItem1";
            this.veterinárioToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.veterinárioToolStripMenuItem1.Text = "Veterinário";
            this.veterinárioToolStripMenuItem1.Click += new System.EventHandler(this.veterinárioToolStripMenuItem1_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veterinárioToolStripMenuItem2});
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // veterinárioToolStripMenuItem2
            // 
            this.veterinárioToolStripMenuItem2.Name = "veterinárioToolStripMenuItem2";
            this.veterinárioToolStripMenuItem2.Size = new System.Drawing.Size(130, 22);
            this.veterinárioToolStripMenuItem2.Text = "Veterinário";
            this.veterinárioToolStripMenuItem2.Click += new System.EventHandler(this.veterinárioToolStripMenuItem2_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veterinárioToolStripMenuItem3});
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.alterarToolStripMenuItem.Text = "Alterar";
            // 
            // veterinárioToolStripMenuItem3
            // 
            this.veterinárioToolStripMenuItem3.Name = "veterinárioToolStripMenuItem3";
            this.veterinárioToolStripMenuItem3.Size = new System.Drawing.Size(130, 22);
            this.veterinárioToolStripMenuItem3.Text = "Veterinário";
            this.veterinárioToolStripMenuItem3.Click += new System.EventHandler(this.veterinárioToolStripMenuItem3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 373);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PRINCIPAL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterinárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterinárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterinárioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterinárioToolStripMenuItem3;
    }
}

