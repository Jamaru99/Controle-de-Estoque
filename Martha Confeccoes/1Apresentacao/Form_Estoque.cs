using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Martha_Confeccoes._2Negocio;

namespace Martha_Confeccoes._1Apresentacao
{
    public partial class Form_Estoque : Form
    {
        Locais locais = new Locais();
        Estoque estoque = new Estoque();

        public Form_Estoque()
        {
            InitializeComponent();
            btnCadastrarLocal.Enabled = false;
        }

        private void Form_Estoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'martinhaDataSet2.Fornecedor1'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedor1TableAdapter.Fill(this.martinhaDataSet2.Fornecedor1);
            // TODO: esta linha de código carrega dados na tabela 'martinhaDataSet2.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.martinhaDataSet2.Produto);
            // TODO: esta linha de código carrega dados na tabela 'martinhaDataSet2.Locais'. Você pode movê-la ou removê-la conforme necessário.
            this.locaisTableAdapter.Fill(this.martinhaDataSet2.Locais);
            if (comboLocal.SelectedValue != null)
            {
                LoadTable();
                btnExcluirLocal.Enabled = true;
            }
        }

        private void btnCadastrarLocal_Click(object sender, EventArgs e)
        {
            locais.Descricao = txtLocal.Text;
            locais.Inserir();
            this.locaisTableAdapter.Fill(this.martinhaDataSet2.Locais);
            btnExcluirLocal.Enabled = true;
            MessageBox.Show("Local Cadastrado!", "Sucesso");
        }

        private void btnExcluirLocal_Click(object sender, EventArgs e)
        {
            if(estoque.TemProduto((int)comboLocal.SelectedValue))
            {
                MessageBox.Show("Não se pode excluir um local com produtos registrados", "Erro");
            }
            DialogResult resposta = MessageBox.Show(this, "Tem certeza que deseja excluir o resgistro?", "Alerta",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.None,
                                        MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.No) return;
            if (resposta == DialogResult.Yes)
            {
                locais.Deletar((int)comboLocal.SelectedValue);
                this.locaisTableAdapter.Fill(this.martinhaDataSet2.Locais);
                if (comboLocal.SelectedValue != null) LoadTable();
                else { gridEstoque.DataSource = null; btnExcluirLocal.Enabled = false; }
            }
        }

        private void comboLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboLocal.SelectedValue != null)
            {
                LoadTable();
            }
        }

        private void txtLocal_TextChanged(object sender, EventArgs e)
        {
            if (txtLocal.Text == "") btnCadastrarLocal.Enabled = false;
            else btnCadastrarLocal.Enabled = true;
        }


        //-------------------------------------------

        //--------------------------FUNÇÕES AUXILIARES
        private void LoadTable()
        {
            gridEstoque.DataSource = estoque.Consulta((int)comboLocal.SelectedValue, checkDisponiveis.Checked, checkReservados.Checked, checkVendidos.Checked);
            gridEstoque.Columns["id"].Visible = false;
            lblTotal.Text = "Quantidade no local: " + GetTotal();
        }

        private float GetTotal()
        {
            int total = 0;
            foreach (DataGridViewRow row in gridEstoque.Rows)
            {
                total += int.Parse(row.Cells["Quantidade"].Value.ToString());
            }
            return total;
        }

        private void checkDisponíveis_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDisponiveis.Checked == true) gridEstoque.DataSource = estoque.Consulta((int)comboLocal.SelectedValue, true, checkReservados.Checked, checkVendidos.Checked);
            else gridEstoque.DataSource = estoque.Consulta((int)comboLocal.SelectedValue, false, checkReservados.Checked, checkVendidos.Checked);
        }

        private void checkReservados_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReservados.Checked == true) gridEstoque.DataSource = estoque.Consulta((int)comboLocal.SelectedValue, checkDisponiveis.Checked, true, checkVendidos.Checked);
            else gridEstoque.DataSource = estoque.Consulta((int)comboLocal.SelectedValue, checkDisponiveis.Checked, false, checkVendidos.Checked);
        }



        private void checkVendidos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkVendidos.Checked == true) gridEstoque.DataSource = estoque.Consulta((int)comboLocal.SelectedValue, checkDisponiveis.Checked, checkReservados.Checked, true);
            else gridEstoque.DataSource = estoque.Consulta((int)comboLocal.SelectedValue, checkDisponiveis.Checked, checkReservados.Checked, false);

        }
    }
}
