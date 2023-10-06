namespace OakTecnoProva
{
    partial class FormMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            this.cadastroButton = new System.Windows.Forms.Button();
            this.listagemButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastroButton
            // 
            this.cadastroButton.Location = new System.Drawing.Point(3, 3);
            this.cadastroButton.Name = "cadastroButton";
            this.cadastroButton.Size = new System.Drawing.Size(197, 56);
            this.cadastroButton.TabIndex = 1;
            this.cadastroButton.Text = "Cadastro";
            this.cadastroButton.UseVisualStyleBackColor = true;
            this.cadastroButton.Click += new System.EventHandler(this.cadastrarButton_Click);
            // 
            // listagemButton
            // 
            this.listagemButton.Location = new System.Drawing.Point(3, 65);
            this.listagemButton.Name = "listagemButton";
            this.listagemButton.Size = new System.Drawing.Size(197, 65);
            this.listagemButton.TabIndex = 2;
            this.listagemButton.Text = "Listagem";
            this.listagemButton.UseVisualStyleBackColor = true;
            this.listagemButton.Click += new System.EventHandler(this.listagemButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.AutoSize = true;
            this.sairButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.sairButton.Location = new System.Drawing.Point(0, 133);
            this.sairButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(200, 65);
            this.sairButton.TabIndex = 16;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.UseWaitCursor = true;
            this.sairButton.Click += new System.EventHandler(this.Sair_Click);
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(this.cadastroButton);
            flowLayoutPanel1.Controls.Add(this.listagemButton);
            flowLayoutPanel1.Controls.Add(this.sairButton);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(200, 527);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 527);
            this.Controls.Add(flowLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cadastroButton;
        private System.Windows.Forms.Button listagemButton;
        private System.Windows.Forms.Button sairButton;
    }
}

