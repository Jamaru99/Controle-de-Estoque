using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Martha_Confeccoes._2Negocio;
using Martha_Confeccoes._1Apresentacao;

namespace Martha_Confeccoes
{
    public partial class Form_Pedido : Form
    {

        Pedido p = new Pedido();
        Pedido.Item ip = new Pedido.Item();
        bool pedidoCriado;
        bool isEditing;
        int indexRow;

        public Form_Pedido()
        {
            InitializeComponent();
            LoadTablePedido();
            pedidoCriado = false;
            isEditing = false;
            btnCadastrar.Enabled = false;
        }

        private void Form_Pedido_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'martinhaDataSet2.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.FillBy(this.martinhaDataSet2.Produto);
            // TODO: esta linha de código carrega dados na tabela 'martinhaDataSet2.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.martinhaDataSet2.Cliente);
            if (comboClientes.Text == "" || comboProdutos.Text == "")
            {
                txtDataCriacao.Enabled = false;
                txtDataEntrega.Enabled = false;
                comboClientes.Enabled = false;
            }
        }

        
        private void gridPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pedido.Item ip = new Pedido.Item();
            LoadTableItemPedido();
            
            if(gridPedidos.CurrentRow.Cells["Status"].Value.ToString() == "Pendente")
            {
                btnFinalizar.Enabled = true;
                btnCancelar.Enabled = true;
                btnEditar.Enabled = true;
            }
            else
            {
                btnFinalizar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = false;
            }
        }
        private void gridItemPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExcluirItem.Enabled = true;
        }
                            

        private void btnAdicionarItem_Click_1(object sender, EventArgs e)
        {

            if (Validacao.VoltaNoTempoNecessaria(txtDataCriacao.Text, txtDataEntrega.Text))
            {
                MessageBox.Show("A data de entraga já passou", "Erro");
                return;
            }

            if (isEditing)
            {
                ip.IdProduto = (int)comboProdutos.SelectedValue;
                ip.IdPedido = int.Parse(gridPedidos.CurrentRow.Cells["ID"].Value.ToString());
                ip.QtdProduto = Int32.Parse(txtQuantidade.Text);
                ip.Inserir();
                LoadTableItemPedido();
                return;
            }

            if (pedidoCriado == false)
            {
                p.Cliente_cnpj_cpf = (string)comboClientes.SelectedValue;
                p.Status = "Pendente";
                p.Data_criacao = DataSQL(txtDataCriacao.Text);
                p.Data_entrega = DataSQL(txtDataEntrega.Text);
                p.Inserir();
                LoadTablePedido();
                comboClientes.Enabled = false;
                txtDataCriacao.Enabled = false;
                txtDataEntrega.Enabled = false;
                btnCadastrar.Enabled = true;
                gridPedidos.ClearSelection();
                gridPedidos.Rows[gridPedidos.Rows.Count - 1].Selected = true;
                pedidoCriado = true;
            }

            
            ip.IdProduto = (int)comboProdutos.SelectedValue;
            ip.IdPedido = p.GetMax();
            ip.QtdProduto = Int32.Parse(txtQuantidade.Text);
            ip.Inserir();
            LoadTableItemPedido();
            btnExcluirItem.Enabled = true;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                p.Cliente_cnpj_cpf = (string)comboClientes.SelectedValue;
                p.Status = "Pendente";
                p.Data_criacao = DataSQL(txtDataCriacao.Text);
                p.Data_entrega = DataSQL(txtDataEntrega.Text);
                p.Alterar(gridPedidos.CurrentRow.Cells["ID"].Value.ToString());
                LoadTablePedido();
                gridPedidos.ClearSelection();
                gridPedidos.Rows[indexRow].Selected = true;
                isEditing = false;
                LimparCampos();
                txtDataCriacao.Text = "";
                btnEditar.Text = "Editar";
                btnCadastrar.Text = "Cadastrar";
                btnCadastrar.Enabled = false;
                MessageBox.Show("Alterações Salvas!", "Sucesso");
                gridPedidos.Enabled = true;
                return;
            }
            pedidoCriado = false;
            comboClientes.Enabled = true;
            txtDataCriacao.Enabled = true;
            txtDataEntrega.Enabled = true;
            btnCadastrar.Enabled = false;
            comboProdutos.Enabled = false;
            txtQuantidade.Enabled = false;
            btnAdicionarItem.Enabled = false;
            LimparCampos();
            MessageBox.Show("Pedido cadastrado!", "Sucesso");
            gridPedidos.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                LimparCampos();
                txtDataCriacao.Text = "";
                gridPedidos.Enabled = true;
                isEditing = false;
                btnEditar.Text = "Editar";
                btnCadastrar.Text = "Cadastrar";
                gridPedidos.Enabled = true;
            }
            else
            {
                isEditing = true;
                comboClientes.Text = gridPedidos.CurrentRow.Cells["Cliente"].Value.ToString();
                txtDataCriacao.Text = gridPedidos.CurrentRow.Cells["Criação"].Value.ToString();
                txtDataEntrega.Text = gridPedidos.CurrentRow.Cells["Entrega"].Value.ToString();
                indexRow = gridPedidos.CurrentRow.Index;
                btnEditar.Text = "Cancelar";
                btnCadastrar.Text = "Salvar";
                btnCadastrar.Enabled = true;
                gridPedidos.Enabled = false;
            }

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (p.TodosFinalizados(gridPedidos.CurrentRow.Cells["ID"].Value.ToString()))
            {
                p.Finalizar(Int32.Parse(gridPedidos.CurrentRow.Cells["ID"].Value.ToString()));
                LoadTablePedido();
                MessageBox.Show("Pedido finalizado!", "Sucesso");
            }
            else MessageBox.Show("Ainda há itens não finalizados", "Erro");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            p.Cancelar(gridPedidos.CurrentRow.Cells["ID"].Value.ToString());
            LoadTablePedido();
            gridItemPedido.DataSource = null;
            MessageBox.Show("Pedido cancelado!", "Sucesso");
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(this, "Tem certeza que deseja excluir o resgistro? Ordens de produção e itens no estoque referentes a este item serão deletados", "Alerta",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.None,
                                        MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.No) return;
            if (resposta == DialogResult.Yes)
            {
                ip.Deletar(gridItemPedido.CurrentRow.Cells["id"].Value.ToString());
                LoadTableItemPedido();
            }
            
        }

        

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            if (txtDataCriacao.Text.Length == 10 && txtDataEntrega.Text.Length == 10)
            {
                comboProdutos.Enabled = true;
                txtQuantidade.Enabled = true;
            }
            else
            {
                comboProdutos.Enabled = false;
                txtQuantidade.Enabled = false;
                if(Validacao.IsPositiveInteger(txtQuantidade.Text) == false) btnAdicionarItem.Enabled = false;
            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidade.Text != "") btnAdicionarItem.Enabled = true;
            else btnAdicionarItem.Enabled = false;
        }

        private void checkPendentes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPendentes.Checked == true) gridPedidos.DataSource = p.Consulta(txtPesquisa.Text, true, checkFinalizados.Checked, checkCancelados.Checked);
            else gridPedidos.DataSource = p.Consulta(txtPesquisa.Text, false, checkFinalizados.Checked, checkCancelados.Checked);
        }

        private void checkFinalizados_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFinalizados.Checked == true) gridPedidos.DataSource = p.Consulta(txtPesquisa.Text, checkPendentes.Checked, true, checkCancelados.Checked);
            else gridPedidos.DataSource = p.Consulta(txtPesquisa.Text, checkPendentes.Checked, false, checkCancelados.Checked);
        }

        private void checkCancelados_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCancelados.Checked == true) gridPedidos.DataSource = p.Consulta(txtPesquisa.Text, checkPendentes.Checked, checkFinalizados.Checked, true);
            else gridPedidos.DataSource = p.Consulta(txtPesquisa.Text, checkPendentes.Checked, checkFinalizados.Checked, false);
        }

        private void Filtrar(object sender, EventArgs e)
        {
            LoadTablePedido();
            gridItemPedido.DataSource = null;
        }

        //--------------------------

        //---------------VALIDAÇÕES
        private void txtQuantidade_Validating(object sender, CancelEventArgs e)
        {
            if (Validacao.IsPositiveInteger(txtQuantidade.Text) || txtQuantidade.Text == "") e.Cancel = false;
            else { e.Cancel = true; MessageBox.Show("Digite um valor inteiro maior que 0", "Erro"); }
        }

        private void txtDataCriacao_Validating(object sender, CancelEventArgs e)
        {
            if (Validacao.DataValida(txtDataCriacao.Text) || txtDataCriacao.Text == "  /  /") e.Cancel = false;
            else { e.Cancel = true; MessageBox.Show("Digite uma data válida", "Erro"); }
        }

        private void txtDataEntrega_Validating(object sender, CancelEventArgs e)
        {
            if (Validacao.DataValida(txtDataEntrega.Text) || txtDataEntrega.Text == "  /  /") e.Cancel = false;
            else { e.Cancel = true; MessageBox.Show("Digite uma data válida", "Erro"); }
        }

        //-------------
        private void LoadTablePedido()
        {

            gridPedidos.DataSource = p.Consulta(txtPesquisa.Text, checkPendentes.Checked, checkFinalizados.Checked, checkCancelados.Checked);
            gridPedidos.ClearSelection();
        }

        private void LoadTableItemPedido()
        {
            gridItemPedido.DataSource = ip.Consulta(gridPedidos.CurrentRow.Cells["ID"].Value.ToString());
            gridItemPedido.Columns["id"].Visible = false;
            gridItemPedido.Columns["Preco"].Visible = false;
            lblTotal.Text = "Total: R$ " + GetTotal();
            gridItemPedido.ClearSelection();
            btnExcluirItem.Enabled = false;
        }

        private void LimparCampos()
        {
            txtDataEntrega.Text = "";
            txtQuantidade.Text = "";
        }

        private float GetTotal()
        {
            float total = 0;
            foreach (DataGridViewRow row in gridItemPedido.Rows)
            {
                total += float.Parse(row.Cells["Quantidade"].Value.ToString()) * float.Parse(row.Cells["Preco"].Value.ToString());
            }
            return total;
        }


        public string DataSQL(string txtDD_MM_YYYY)
        {
            return string.Concat("DATEFROMPARTS(",
                                  txtDD_MM_YYYY.Substring(6, 4),
                                  ",",
                                  txtDD_MM_YYYY.Substring(3, 2),
                                  ",",
                                  txtDD_MM_YYYY.Substring(0, 2),
                                  ")");
        }

    }
}
