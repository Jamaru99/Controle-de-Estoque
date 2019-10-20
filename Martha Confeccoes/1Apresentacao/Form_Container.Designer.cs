namespace Martha_Confeccoes._1Apresentacao
{
    partial class Form_Container
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Container));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protudoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produçãoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.protudoMenuItem,
            this.clienteMenuItem,
            this.fornecedoresMenuItem,
            this.estoqueMenuItem,
            this.produçãoMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "Cadastros";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosMenuItem_Click);
            // 
            // protudoMenuItem
            // 
            this.protudoMenuItem.Name = "protudoMenuItem";
            this.protudoMenuItem.Size = new System.Drawing.Size(67, 20);
            this.protudoMenuItem.Text = "Produtos";
            this.protudoMenuItem.Click += new System.EventHandler(this.produtosMenuItem_Click);
            // 
            // clienteMenuItem
            // 
            this.clienteMenuItem.Name = "clienteMenuItem";
            this.clienteMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clienteMenuItem.Text = "Clientes";
            this.clienteMenuItem.Click += new System.EventHandler(this.clienteMenuItem_Click);
            // 
            // fornecedoresMenuItem
            // 
            this.fornecedoresMenuItem.Name = "fornecedoresMenuItem";
            this.fornecedoresMenuItem.Size = new System.Drawing.Size(90, 20);
            this.fornecedoresMenuItem.Text = "Fornecedores";
            this.fornecedoresMenuItem.Click += new System.EventHandler(this.fornecedoresMenuItem_Click);
            // 
            // estoqueMenuItem
            // 
            this.estoqueMenuItem.Name = "estoqueMenuItem";
            this.estoqueMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueMenuItem.Text = "Estoque";
            this.estoqueMenuItem.Click += new System.EventHandler(this.estoqueMenuItem_Click);
            // 
            // produçãoMenuItem
            // 
            this.produçãoMenuItem.Name = "produçãoMenuItem";
            this.produçãoMenuItem.Size = new System.Drawing.Size(70, 20);
            this.produçãoMenuItem.Text = "Produção";
            this.produçãoMenuItem.Click += new System.EventHandler(this.produçãoMenuItem_Click);
            // 
            // Form_Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "Form_Container";
            this.Text = "Martha Confecções";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem protudoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produçãoMenuItem;
    }
}