namespace Martha_Confeccoes
{
    partial class Form_Produto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.radioMP = new System.Windows.Forms.RadioButton();
            this.radioPA = new System.Windows.Forms.RadioButton();
            this.MP_PA = new System.Windows.Forms.GroupBox();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtPrecoFilterMin = new System.Windows.Forms.TextBox();
            this.txtPrecoFilterMax = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtTamanhoFilterMax = new System.Windows.Forms.TextBox();
            this.txtTamanhoFilterMin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkMP = new System.Windows.Forms.CheckBox();
            this.checkPA = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MP_PA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(115, 34);
            this.txtDescricao.MaxLength = 30;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tamanho:";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(115, 104);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(100, 20);
            this.txtTamanho.TabIndex = 2;
            this.txtTamanho.TextChanged += new System.EventHandler(this.TextChanged);
            this.txtTamanho.Validating += new System.ComponentModel.CancelEventHandler(this.txtTamanho_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(115, 70);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 1;
            this.txtPreco.TextChanged += new System.EventHandler(this.TextChanged);
            this.txtPreco.Validating += new System.ComponentModel.CancelEventHandler(this.txtPreco_Validating);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(90, 257);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // radioMP
            // 
            this.radioMP.AutoSize = true;
            this.radioMP.Location = new System.Drawing.Point(22, 29);
            this.radioMP.Name = "radioMP";
            this.radioMP.Size = new System.Drawing.Size(89, 17);
            this.radioMP.TabIndex = 11;
            this.radioMP.Text = "Matéria Prima";
            this.radioMP.UseVisualStyleBackColor = true;
            this.radioMP.CheckedChanged += new System.EventHandler(this.radioMP_CheckedChanged);
            // 
            // radioPA
            // 
            this.radioPA.AutoSize = true;
            this.radioPA.Checked = true;
            this.radioPA.Location = new System.Drawing.Point(22, 52);
            this.radioPA.Name = "radioPA";
            this.radioPA.Size = new System.Drawing.Size(108, 17);
            this.radioPA.TabIndex = 12;
            this.radioPA.TabStop = true;
            this.radioPA.Text = "Produto Acabado";
            this.radioPA.UseVisualStyleBackColor = true;
            this.radioPA.CheckedChanged += new System.EventHandler(this.radioPA_CheckedChanged);
            // 
            // MP_PA
            // 
            this.MP_PA.Controls.Add(this.radioMP);
            this.MP_PA.Controls.Add(this.radioPA);
            this.MP_PA.Location = new System.Drawing.Point(45, 149);
            this.MP_PA.Name = "MP_PA";
            this.MP_PA.Size = new System.Drawing.Size(170, 81);
            this.MP_PA.TabIndex = 13;
            this.MP_PA.TabStop = false;
            this.MP_PA.Text = "O produto é:";
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProducts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridProducts.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridProducts.Location = new System.Drawing.Point(270, 174);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.ShowEditingIcon = false;
            this.gridProducts.Size = new System.Drawing.Size(444, 229);
            this.gridProducts.TabIndex = 14;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(119, 23);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(289, 20);
            this.txtPesquisa.TabIndex = 16;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(389, 416);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(515, 416);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtPrecoFilterMin
            // 
            this.txtPrecoFilterMin.Location = new System.Drawing.Point(119, 57);
            this.txtPrecoFilterMin.Name = "txtPrecoFilterMin";
            this.txtPrecoFilterMin.Size = new System.Drawing.Size(72, 20);
            this.txtPrecoFilterMin.TabIndex = 19;
            // 
            // txtPrecoFilterMax
            // 
            this.txtPrecoFilterMax.Location = new System.Drawing.Point(228, 57);
            this.txtPrecoFilterMax.Name = "txtPrecoFilterMax";
            this.txtPrecoFilterMax.Size = new System.Drawing.Size(75, 20);
            this.txtPrecoFilterMax.TabIndex = 20;
            this.txtPrecoFilterMax.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecoFilterMax_Validating);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(333, 72);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 21;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtTamanhoFilterMax
            // 
            this.txtTamanhoFilterMax.Location = new System.Drawing.Point(228, 89);
            this.txtTamanhoFilterMax.Name = "txtTamanhoFilterMax";
            this.txtTamanhoFilterMax.Size = new System.Drawing.Size(75, 20);
            this.txtTamanhoFilterMax.TabIndex = 23;
            this.txtTamanhoFilterMax.Validating += new System.ComponentModel.CancelEventHandler(this.txtTamanhoFilterMax_Validating);
            // 
            // txtTamanhoFilterMin
            // 
            this.txtTamanhoFilterMin.Location = new System.Drawing.Point(119, 89);
            this.txtTamanhoFilterMin.Name = "txtTamanhoFilterMin";
            this.txtTamanhoFilterMin.Size = new System.Drawing.Size(72, 20);
            this.txtTamanhoFilterMin.TabIndex = 22;
            this.txtTamanhoFilterMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtTamanhoFilterMin_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkMP);
            this.groupBox1.Controls.Add(this.checkPA);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.txtTamanhoFilterMax);
            this.groupBox1.Controls.Add(this.txtPrecoFilterMin);
            this.groupBox1.Controls.Add(this.txtTamanhoFilterMin);
            this.groupBox1.Controls.Add(this.txtPrecoFilterMax);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Location = new System.Drawing.Point(270, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 161);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // checkMP
            // 
            this.checkMP.AutoSize = true;
            this.checkMP.Checked = true;
            this.checkMP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMP.Location = new System.Drawing.Point(228, 136);
            this.checkMP.Name = "checkMP";
            this.checkMP.Size = new System.Drawing.Size(90, 17);
            this.checkMP.TabIndex = 28;
            this.checkMP.Text = "Matéria Prima";
            this.checkMP.UseVisualStyleBackColor = true;
            // 
            // checkPA
            // 
            this.checkPA.AutoSize = true;
            this.checkPA.Checked = true;
            this.checkPA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPA.Location = new System.Drawing.Point(119, 136);
            this.checkPA.Name = "checkPA";
            this.checkPA.Size = new System.Drawing.Size(109, 17);
            this.checkPA.TabIndex = 27;
            this.checkPA.Text = "Produto Acabado";
            this.checkPA.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tamanho:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Descrição:";
            // 
            // Form_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 447);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gridProducts);
            this.Controls.Add(this.MP_PA);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Produto";
            this.Text = "Produtos";
            this.MP_PA.ResumeLayout(false);
            this.MP_PA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.RadioButton radioMP;
        private System.Windows.Forms.RadioButton radioPA;
        private System.Windows.Forms.GroupBox MP_PA;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtPrecoFilterMax;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtTamanhoFilterMax;
        private System.Windows.Forms.TextBox txtTamanhoFilterMin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrecoFilterMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkMP;
        private System.Windows.Forms.CheckBox checkPA;
    }
}