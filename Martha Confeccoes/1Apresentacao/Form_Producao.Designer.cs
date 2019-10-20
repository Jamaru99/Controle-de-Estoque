namespace Martha_Confeccoes._1Apresentacao
{
    partial class Form_Producao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridProducao = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.comboLocal = new System.Windows.Forms.ComboBox();
            this.locaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.martinhaDataSet2 = new Martha_Confeccoes.martinhaDataSet2();
            this.locaisTableAdapter = new Martha_Confeccoes.martinhaDataSet2TableAdapters.LocaisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.martinhaDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProducao
            // 
            this.gridProducao.AllowUserToAddRows = false;
            this.gridProducao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridProducao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProducao.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridProducao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProducao.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridProducao.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridProducao.Location = new System.Drawing.Point(201, 47);
            this.gridProducao.MultiSelect = false;
            this.gridProducao.Name = "gridProducao";
            this.gridProducao.ReadOnly = true;
            this.gridProducao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducao.ShowEditingIcon = false;
            this.gridProducao.Size = new System.Drawing.Size(438, 278);
            this.gridProducao.TabIndex = 45;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(388, 355);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 46;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // comboLocal
            // 
            this.comboLocal.DataSource = this.locaisBindingSource;
            this.comboLocal.DisplayMember = "descricao";
            this.comboLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLocal.FormattingEnabled = true;
            this.comboLocal.Location = new System.Drawing.Point(27, 169);
            this.comboLocal.Name = "comboLocal";
            this.comboLocal.Size = new System.Drawing.Size(121, 21);
            this.comboLocal.TabIndex = 47;
            this.comboLocal.ValueMember = "id";
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
            // locaisTableAdapter
            // 
            this.locaisTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Producao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 394);
            this.Controls.Add(this.comboLocal);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.gridProducao);
            this.Name = "Form_Producao";
            this.Text = "Form_Producao";
            this.Load += new System.EventHandler(this.Form_Producao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.martinhaDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProducao;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ComboBox comboLocal;
        private martinhaDataSet2 martinhaDataSet2;
        private System.Windows.Forms.BindingSource locaisBindingSource;
        private martinhaDataSet2TableAdapters.LocaisTableAdapter locaisTableAdapter;
    }
}