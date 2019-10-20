namespace Martha_Confeccoes
{
    partial class Form_Pedido
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridPedidos = new System.Windows.Forms.DataGridView();
            this.gridItemPedido = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.checkPendentes = new System.Windows.Forms.CheckBox();
            this.checkFinalizados = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkCancelados = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataEntrega = new System.Windows.Forms.MaskedTextBox();
            this.txtDataCriacao = new System.Windows.Forms.MaskedTextBox();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.martinhaDataSet2 = new Martha_Confeccoes.martinhaDataSet2();
            this.comboProdutos = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.produtoTableAdapter = new Martha_Confeccoes.martinhaDataSet2TableAdapters.ProdutoTableAdapter();
            this.clienteTableAdapter = new Martha_Confeccoes.martinhaDataSet2TableAdapters.ClienteTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemPedido)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.martinhaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPedidos
            // 
            this.gridPedidos.AllowUserToAddRows = false;
            this.gridPedidos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPedidos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridPedidos.Location = new System.Drawing.Point(27, 61);
            this.gridPedidos.MultiSelect = false;
            this.gridPedidos.Name = "gridPedidos";
            this.gridPedidos.ReadOnly = true;
            this.gridPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPedidos.ShowEditingIcon = false;
            this.gridPedidos.Size = new System.Drawing.Size(544, 231);
            this.gridPedidos.TabIndex = 7;
            this.gridPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPedidos_CellContentClick);
            // 
            // gridItemPedido
            // 
            this.gridItemPedido.AllowUserToAddRows = false;
            this.gridItemPedido.AllowUserToDeleteRows = false;
            this.gridItemPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridItemPedido.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridItemPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridItemPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItemPedido.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridItemPedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridItemPedido.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridItemPedido.Location = new System.Drawing.Point(604, 61);
            this.gridItemPedido.MultiSelect = false;
            this.gridItemPedido.Name = "gridItemPedido";
            this.gridItemPedido.ReadOnly = true;
            this.gridItemPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItemPedido.ShowEditingIcon = false;
            this.gridItemPedido.Size = new System.Drawing.Size(344, 231);
            this.gridItemPedido.TabIndex = 16;
            this.gridItemPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItemPedido_CellContentClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(27, 33);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(153, 22);
            this.txtPesquisa.TabIndex = 19;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.Filtrar);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(422, 313);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 20;
            this.btnFinalizar.Text = "Finalizar Pedido";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // checkPendentes
            // 
            this.checkPendentes.AutoSize = true;
            this.checkPendentes.Checked = true;
            this.checkPendentes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPendentes.Location = new System.Drawing.Point(186, 35);
            this.checkPendentes.Name = "checkPendentes";
            this.checkPendentes.Size = new System.Drawing.Size(92, 20);
            this.checkPendentes.TabIndex = 21;
            this.checkPendentes.Text = "Pendentes";
            this.checkPendentes.UseVisualStyleBackColor = true;
            this.checkPendentes.CheckedChanged += new System.EventHandler(this.checkPendentes_CheckedChanged);
            // 
            // checkFinalizados
            // 
            this.checkFinalizados.AutoSize = true;
            this.checkFinalizados.Location = new System.Drawing.Point(284, 35);
            this.checkFinalizados.Name = "checkFinalizados";
            this.checkFinalizados.Size = new System.Drawing.Size(96, 20);
            this.checkFinalizados.TabIndex = 22;
            this.checkFinalizados.Text = "Finalizados";
            this.checkFinalizados.UseVisualStyleBackColor = true;
            this.checkFinalizados.CheckedChanged += new System.EventHandler(this.checkFinalizados_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkCancelados);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnExcluirItem);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.checkFinalizados);
            this.groupBox1.Controls.Add(this.gridItemPedido);
            this.groupBox1.Controls.Add(this.checkPendentes);
            this.groupBox1.Controls.Add(this.btnFinalizar);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.gridPedidos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 345);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos Cadastrados";
            // 
            // checkCancelados
            // 
            this.checkCancelados.AutoSize = true;
            this.checkCancelados.Location = new System.Drawing.Point(386, 35);
            this.checkCancelados.Name = "checkCancelados";
            this.checkCancelados.Size = new System.Drawing.Size(100, 20);
            this.checkCancelados.TabIndex = 44;
            this.checkCancelados.Text = "Cancelados";
            this.checkCancelados.UseVisualStyleBackColor = true;
            this.checkCancelados.CheckedChanged += new System.EventHandler(this.checkCancelados_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(316, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Enabled = false;
            this.btnExcluirItem.Location = new System.Drawing.Point(744, 313);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirItem.TabIndex = 42;
            this.btnExcluirItem.Text = "Excluir";
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(126, 313);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(633, 295);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 16);
            this.lblTotal.TabIndex = 40;
            this.lblTotal.Text = "Total: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Itens:";
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.Location = new System.Drawing.Point(368, 142);
            this.txtDataEntrega.Mask = "00/00/0000";
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Size = new System.Drawing.Size(100, 20);
            this.txtDataEntrega.TabIndex = 29;
            this.txtDataEntrega.ValidatingType = typeof(System.DateTime);
            this.txtDataEntrega.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            this.txtDataEntrega.Validating += new System.ComponentModel.CancelEventHandler(this.txtDataEntrega_Validating);
            // 
            // txtDataCriacao
            // 
            this.txtDataCriacao.Location = new System.Drawing.Point(368, 97);
            this.txtDataCriacao.Mask = "00/00/0000";
            this.txtDataCriacao.Name = "txtDataCriacao";
            this.txtDataCriacao.Size = new System.Drawing.Size(100, 20);
            this.txtDataCriacao.TabIndex = 28;
            this.txtDataCriacao.ValidatingType = typeof(System.DateTime);
            this.txtDataCriacao.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            this.txtDataCriacao.Validating += new System.ComponentModel.CancelEventHandler(this.txtDataCriacao_Validating);
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Enabled = false;
            this.btnAdicionarItem.Location = new System.Drawing.Point(95, 135);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarItem.TabIndex = 26;
            this.btnAdicionarItem.Text = "Adicionar";
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click_1);
            // 
            // comboClientes
            // 
            this.comboClientes.BackColor = System.Drawing.Color.White;
            this.comboClientes.DataSource = this.clienteBindingSource;
            this.comboClientes.DisplayMember = "razao_social";
            this.comboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(364, 53);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(121, 21);
            this.comboClientes.TabIndex = 25;
            this.comboClientes.ValueMember = "cnpj_cpf";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.martinhaDataSet2;
            // 
            // martinhaDataSet2
            // 
            this.martinhaDataSet2.DataSetName = "martinhaDataSet2";
            this.martinhaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboProdutos
            // 
            this.comboProdutos.DataSource = this.produtoBindingSource;
            this.comboProdutos.DisplayMember = "Descricao";
            this.comboProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProdutos.Enabled = false;
            this.comboProdutos.FormattingEnabled = true;
            this.comboProdutos.Location = new System.Drawing.Point(82, 34);
            this.comboProdutos.Name = "comboProdutos";
            this.comboProdutos.Size = new System.Drawing.Size(121, 21);
            this.comboProdutos.TabIndex = 24;
            this.comboProdutos.ValueMember = "Id";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.martinhaDataSet2;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(82, 91);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 23;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            this.txtQuantidade.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantidade_Validating);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(469, 199);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(107, 23);
            this.btnCadastrar.TabIndex = 33;
            this.btnCadastrar.Text = "Finalizar Cadastro";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Quantidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Cliente:";
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Data de entrega:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Data do pedido:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdicionarItem);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboProdutos);
            this.groupBox2.Location = new System.Drawing.Point(560, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 165);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens";
            // 
            // Form_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1020, 581);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataEntrega);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDataCriacao);
            this.Controls.Add(this.comboClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Pedido";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Form_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemPedido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.martinhaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridPedidos;
        private System.Windows.Forms.DataGridView gridItemPedido;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.CheckBox checkPendentes;
        private System.Windows.Forms.CheckBox checkFinalizados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtDataEntrega;
        private System.Windows.Forms.MaskedTextBox txtDataCriacao;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.ComboBox comboProdutos;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private martinhaDataSet2 martinhaDataSet2;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private martinhaDataSet2TableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private martinhaDataSet2TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox checkCancelados;
    }
}

