namespace Martha_Confeccoes._1Apresentacao
{
    partial class Form_Estoque
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCadastrarLocal = new System.Windows.Forms.Button();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.comboLocal = new System.Windows.Forms.ComboBox();
            this.locaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.martinhaDataSet2 = new Martha_Confeccoes.martinhaDataSet2();
            this.gridEstoque = new System.Windows.Forms.DataGridView();
            this.locaisTableAdapter = new Martha_Confeccoes.martinhaDataSet2TableAdapters.LocaisTableAdapter();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new Martha_Confeccoes.martinhaDataSet2TableAdapters.ProdutoTableAdapter();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueTableAdapter = new Martha_Confeccoes.martinhaDataSet2TableAdapters.EstoqueTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.fornecedor1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedor1TableAdapter = new Martha_Confeccoes.martinhaDataSet2TableAdapters.Fornecedor1TableAdapter();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnExcluirLocal = new System.Windows.Forms.Button();
            this.checkVendidos = new System.Windows.Forms.CheckBox();
            this.checkReservados = new System.Windows.Forms.CheckBox();
            this.checkDisponiveis = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.locaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.martinhaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedor1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarLocal
            // 
            this.btnCadastrarLocal.Location = new System.Drawing.Point(340, 32);
            this.btnCadastrarLocal.Name = "btnCadastrarLocal";
            this.btnCadastrarLocal.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarLocal.TabIndex = 0;
            this.btnCadastrarLocal.Text = "Cadastrar";
            this.btnCadastrarLocal.UseVisualStyleBackColor = true;
            this.btnCadastrarLocal.Click += new System.EventHandler(this.btnCadastrarLocal_Click);
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(214, 32);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(100, 20);
            this.txtLocal.TabIndex = 1;
            this.txtLocal.TextChanged += new System.EventHandler(this.txtLocal_TextChanged);
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(130, 37);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(78, 13);
            this.lblLocal.TabIndex = 2;
            this.lblLocal.Text = "Nome do local:";
            // 
            // comboLocal
            // 
            this.comboLocal.DataSource = this.locaisBindingSource;
            this.comboLocal.DisplayMember = "descricao";
            this.comboLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLocal.FormattingEnabled = true;
            this.comboLocal.Location = new System.Drawing.Point(231, 359);
            this.comboLocal.Name = "comboLocal";
            this.comboLocal.Size = new System.Drawing.Size(121, 21);
            this.comboLocal.TabIndex = 3;
            this.comboLocal.ValueMember = "id";
            this.comboLocal.SelectedIndexChanged += new System.EventHandler(this.comboLocal_SelectedIndexChanged);
            // 
            // locaisBindingSource
            // 
            this.locaisBindingSource.DataMember = "Locais";
            this.locaisBindingSource.DataSource = this.martinhaDataSet2;
            // 
            // martinhaDataSet2
            // 
            this.martinhaDataSet2.DataSetName = "martinhaDataSet2";
            this.martinhaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridEstoque
            // 
            this.gridEstoque.AllowUserToAddRows = false;
            this.gridEstoque.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridEstoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridEstoque.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridEstoque.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridEstoque.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridEstoque.Location = new System.Drawing.Point(53, 80);
            this.gridEstoque.MultiSelect = false;
            this.gridEstoque.Name = "gridEstoque";
            this.gridEstoque.ReadOnly = true;
            this.gridEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEstoque.ShowEditingIcon = false;
            this.gridEstoque.Size = new System.Drawing.Size(446, 231);
            this.gridEstoque.TabIndex = 8;
            // 
            // locaisTableAdapter
            // 
            this.locaisTableAdapter.ClearBeforeFill = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.martinhaDataSet2;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "Estoque";
            this.estoqueBindingSource.DataSource = this.martinhaDataSet2;
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Local:";
            // 
            // fornecedor1BindingSource
            // 
            this.fornecedor1BindingSource.DataMember = "Fornecedor1";
            this.fornecedor1BindingSource.DataSource = this.martinhaDataSet2;
            // 
            // fornecedor1TableAdapter
            // 
            this.fornecedor1TableAdapter.ClearBeforeFill = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(86, 395);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(139, 17);
            this.lblTotal.TabIndex = 41;
            this.lblTotal.Text = "Quantidade no local:";
            // 
            // btnExcluirLocal
            // 
            this.btnExcluirLocal.Enabled = false;
            this.btnExcluirLocal.Location = new System.Drawing.Point(231, 431);
            this.btnExcluirLocal.Name = "btnExcluirLocal";
            this.btnExcluirLocal.Size = new System.Drawing.Size(121, 23);
            this.btnExcluirLocal.TabIndex = 43;
            this.btnExcluirLocal.Text = "Excluir Local";
            this.btnExcluirLocal.UseVisualStyleBackColor = true;
            this.btnExcluirLocal.Click += new System.EventHandler(this.btnExcluirLocal_Click);
            // 
            // checkVendidos
            // 
            this.checkVendidos.AutoSize = true;
            this.checkVendidos.Location = new System.Drawing.Point(333, 317);
            this.checkVendidos.Name = "checkVendidos";
            this.checkVendidos.Size = new System.Drawing.Size(70, 17);
            this.checkVendidos.TabIndex = 47;
            this.checkVendidos.Text = "Vendidos";
            this.checkVendidos.UseVisualStyleBackColor = true;
            this.checkVendidos.CheckedChanged += new System.EventHandler(this.checkVendidos_CheckedChanged);
            // 
            // checkReservados
            // 
            this.checkReservados.AutoSize = true;
            this.checkReservados.Checked = true;
            this.checkReservados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkReservados.Location = new System.Drawing.Point(236, 317);
            this.checkReservados.Name = "checkReservados";
            this.checkReservados.Size = new System.Drawing.Size(83, 17);
            this.checkReservados.TabIndex = 46;
            this.checkReservados.Text = "Reservados";
            this.checkReservados.UseVisualStyleBackColor = true;
            this.checkReservados.CheckedChanged += new System.EventHandler(this.checkReservados_CheckedChanged);
            // 
            // checkDisponiveis
            // 
            this.checkDisponiveis.AutoSize = true;
            this.checkDisponiveis.Checked = true;
            this.checkDisponiveis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDisponiveis.Location = new System.Drawing.Point(140, 317);
            this.checkDisponiveis.Name = "checkDisponiveis";
            this.checkDisponiveis.Size = new System.Drawing.Size(82, 17);
            this.checkDisponiveis.TabIndex = 45;
            this.checkDisponiveis.Text = "Disponíveis";
            this.checkDisponiveis.UseVisualStyleBackColor = true;
            this.checkDisponiveis.CheckedChanged += new System.EventHandler(this.checkDisponíveis_CheckedChanged);
            // 
            // Form_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 466);
            this.Controls.Add(this.checkVendidos);
            this.Controls.Add(this.checkReservados);
            this.Controls.Add(this.checkDisponiveis);
            this.Controls.Add(this.btnExcluirLocal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridEstoque);
            this.Controls.Add(this.comboLocal);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.btnCadastrarLocal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Estoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Form_Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.martinhaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedor1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarLocal;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.ComboBox comboLocal;
        private System.Windows.Forms.DataGridView gridEstoque;
        private martinhaDataSet2 martinhaDataSet2;
        private System.Windows.Forms.BindingSource locaisBindingSource;
        private martinhaDataSet2TableAdapters.LocaisTableAdapter locaisTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private martinhaDataSet2TableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private martinhaDataSet2TableAdapters.EstoqueTableAdapter estoqueTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource fornecedor1BindingSource;
        private martinhaDataSet2TableAdapters.Fornecedor1TableAdapter fornecedor1TableAdapter;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnExcluirLocal;
        private System.Windows.Forms.CheckBox checkVendidos;
        private System.Windows.Forms.CheckBox checkReservados;
        private System.Windows.Forms.CheckBox checkDisponiveis;
    }
}