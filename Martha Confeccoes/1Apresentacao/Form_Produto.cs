using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Martha_Confeccoes._1Apresentacao;
using Martha_Confeccoes._2Negocio;
using System.Globalization;

namespace Martha_Confeccoes
{
    public partial class Form_Produto : Form
    {
        Produto produto = new Produto();
        bool isEditing = false;

        public Form_Produto()
        {
            InitializeComponent();
            LoadTable(false);
            btnCadastrar.Enabled = false;
            gridProducts.Columns["Id"].Visible = false;
            if(gridProducts.Rows.Count == 0) { btnEditar.Enabled = false; btnExcluir.Enabled = false; }
        }
    

        private void btnCadastrar_Click(object sender, EventArgs e)
        {            
            produto.Descricao = txtDescricao.Text;
            if (txtTamanho.Text != "") produto.Tamanho = txtTamanho.Text; else produto.Tamanho = "null";
            produto.Preco = txtPreco.Text;
            if (produto.Preco.Contains(',')) produto.Preco = produto.Preco.Replace(',', '.');
            produto.IsPA = radioPA.Checked ? 1 : 0;

            if (isEditing)
            {
                produto.Alterar(gridProducts.CurrentRow.Cells["Id"].Value.ToString());
                MessageBox.Show("Produto Alterado!", "Sucesso");
            }
            else { produto.Inserir(); MessageBox.Show("Produto cadastrado!", "Sucesso"); }

            LoadTable(false);
            gridProducts.ClearSelection();
            gridProducts.Rows[gridProducts.Rows.Count - 1].Selected = true;
            LimparCampos();
            isEditing = false;
            btnCadastrar.Text = "Cadastrar";
            btnEditar.Text = "Editar";
            gridProducts.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        
        }

        private void txtPreco_Validating(object sender, CancelEventArgs e)
        {
            if (Validacao.IsDouble(txtPreco.Text) || txtPreco.Text == "") e.Cancel = false;
            else { e.Cancel = true; MessageBox.Show("Digite apenas valores numéricos positivos", "Erro"); }
        }

        private void txtPrecoFilterMax_Validating(object sender, CancelEventArgs e)
        {
            if (Validacao.IsDouble(txtPrecoFilterMax.Text) || txtPrecoFilterMax.Text == "") e.Cancel = false;
            else { e.Cancel = true; MessageBox.Show("Digite apenas valores numéricos positivos", "Erro"); }
        }

        private void txtPrecoFilterMin_Validating(object sender, CancelEventArgs e)
        {
            if (Validacao.IsDouble(txtPrecoFilterMin.Text) || txtPrecoFilterMin.Text == "") e.Cancel = false;
            else { e.Cancel = true; MessageBox.Show("Digite apenas valores numéricos positivos", "Erro"); }
        }

        private void txtTamanho_Validating(object sender, CancelEventArgs e)
        {
            if (Validacao.IsPositiveInteger(txtTamanho.Text) || txtTamanho.Text == "") e.Cancel = false;
            else { e.Cancel = true; MessageBox.Show("Digite um valor inteiro maior que 0", "Erro"); }
        }

        private void txtTamanhoFilterMax_Validating(object sender, CancelEventArgs e)
        {
            if (Validacao.IsPositiveInteger(txtTamanhoFilterMax.Text) || txtTamanhoFilterMax.Text == "") e.Cancel = false;
            else { e.Cancel = true; MessageBox.Show("Digite um valor inteiro maior que 0", "Erro"); }
        }

        private void txtTamanhoFilterMin_Validating(object sender, CancelEventArgs e)
        {
            if (Validacao.IsPositiveInteger(txtTamanhoFilterMin.Text) || txtTamanhoFilterMin.Text == "") e.Cancel = false;
            else { e.Cancel = true; MessageBox.Show("Digite um valor inteiro maior que 0", "Erro"); }
        }

        private void radioMP_CheckedChanged(object sender, EventArgs e)
        {
            txtTamanho.Text = "";
            txtTamanho.Enabled = false;
            if (txtPreco.Text != "" && txtDescricao.Text != "") btnCadastrar.Enabled = true;
        }

        private void radioPA_CheckedChanged(object sender, EventArgs e)
        {
            txtTamanho.Enabled = true;
            btnCadastrar.Enabled = false;
        }

        private void TextChanged(object sender, EventArgs e)
        {

            if (txtPreco.Text != "" && txtDescricao.Text != "" && radioMP.Checked ||
               txtPreco.Text != "" && txtDescricao.Text != "" && txtTamanho.Text != "" && radioPA.Checked)
            {
                btnCadastrar.Enabled = true;
            }
            else btnCadastrar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (gridProducts.SelectedRows.Count != 1)
            {
                MessageBox.Show(this, "Selecione na grade o ítem a ser excluído!", "Falta informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resposta = MessageBox.Show(this, "Tem certeza que deseja excluir o resgistro?", "Alerta",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.None,
                                        MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.No) return;
            if (resposta == DialogResult.Yes)
            {
                produto.Deletar(gridProducts.CurrentRow.Cells["Id"].Value.ToString());
                LoadTable(false);
            }
            if (gridProducts.Rows.Count == 0) { btnEditar.Enabled = false; btnExcluir.Enabled = false; }
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gridProducts.Enabled = false;
            if (isEditing)
            {
                isEditing = false;
                btnCadastrar.Text = "Cadastrar";
                btnEditar.Text = "Editar";
                
                gridProducts.Enabled = true;
                LimparCampos();
            }
            else
            {
                isEditing = true;
                btnCadastrar.Text = "Salvar";
                btnEditar.Text = "Cancelar";

                txtDescricao.Text = gridProducts.CurrentRow.Cells["Descricao"].Value.ToString();
                txtPreco.Text = gridProducts.CurrentRow.Cells["Preco"].Value.ToString();
                string mp_pa = gridProducts.CurrentRow.Cells["Tipo"].Value.ToString();
                if (mp_pa == "Matéria Prima")
                {
                    txtTamanho.Text = "";
                    txtTamanho.Enabled = false;
                    radioMP.Checked = true;
                }
                else
                {
                    txtTamanho.Text = gridProducts.CurrentRow.Cells["Tamanho"].Value.ToString();
                    radioPA.Checked = true;
                }
            }
        }

        

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            LoadTable(true);
        }

        private void LoadTable(bool filter)
        {
            if (filter)
                gridProducts.DataSource = produto.Consulta(txtPesquisa.Text, txtPrecoFilterMin.Text,
                                                            txtPrecoFilterMax.Text, txtTamanhoFilterMin.Text,
                                                            txtTamanhoFilterMax.Text, checkPA.Checked, checkMP.Checked);
            else gridProducts.DataSource = produto.Consulta();
        }

        private void LimparCampos()
        {
            txtDescricao.Text = "";
            txtPreco.Text = "";
            txtTamanho.Text = "";
        }
    }
}
