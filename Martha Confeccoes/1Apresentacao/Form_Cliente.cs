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
    public partial class Form_Cliente : Form
    {

        Cliente cliente = new Cliente();
        bool isEditing = false;

        public Form_Cliente()
        {
            InitializeComponent();
            LoadTable();
            btnCadastrar.Enabled = false;
            txtPais.Enabled = false;
            if (gridCustomers.Rows.Count == 0) { btnEditar.Enabled = false; btnExcluir.Enabled = false; }
            
        }

        //----------EVENTOS
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                cliente.Cnpj_cpf = txtCnpjCpf.Text;
                cliente.Razao_social = txtRazaoSocial.Text;
                cliente.Inscricao_estadual = txtInscricaoE.Text;
                cliente.Inscricao_municipal = txtInscricaoM.Text;
                cliente.Pais = txtPais.Text;
                cliente.Uf = cboUf.Text;
                cliente.Municipio = txtCidade.Text;
                cliente.Bairro = txtBairro.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Cep = txtCep.Text;
                cliente.Alterar(gridCustomers.CurrentRow.Cells["CPF/CNPJ"].Value.ToString());
                LoadTable();
                MessageBox.Show("Alterações Salvas", "Sucesso");
                isEditing = false;
                btnEditar.Text = "Editar";
                btnCadastrar.Text = "Cadastrar";
                txtCnpjCpf.Enabled = true;
                gridCustomers.Enabled = true;
                LimparCampos();

            }
            else
            { 
                cliente.Cnpj_cpf = txtCnpjCpf.Text;
                cliente.Razao_social = txtRazaoSocial.Text;
                cliente.Inscricao_estadual = txtInscricaoE.Text;
                cliente.Inscricao_municipal = txtInscricaoM.Text;
                cliente.Pais = txtPais.Text;
                cliente.Uf = cboUf.Text;
                cliente.Municipio = txtCidade.Text;
                cliente.Bairro = txtBairro.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Cep = txtCep.Text;

                cliente.Inserir();
                gridCustomers.DataSource = cliente.Consulta();
                btnCadastrar.Enabled = false;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gridCustomers.Enabled = false;
            if (!TudoVazio())
            {
                /*DialogResult resposta = MessageBox.Show(this.Parent, "Deseja descartar as alterações pendentes?", "Alerta",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.None,
                                        MessageBoxDefaultButton.Button2);

                if (resposta == DialogResult.No) return;*/
            }

            if (isEditing)
            {
                isEditing = false;
                btnCadastrar.Text = "Cadastrar";
                btnEditar.Text = "Editar";
                txtCnpjCpf.Enabled = true;
                gridCustomers.Enabled = true;
                LimparCampos();
            }
            else
            {
                isEditing = true;
                btnCadastrar.Text = "Salvar Alterações";
                btnEditar.Text = "Cancelar";

                txtCnpjCpf.Text = gridCustomers.CurrentRow.Cells["CPF/CNPJ"].Value.ToString();
                txtCnpjCpf.Enabled = false;
                txtRazaoSocial.Text = gridCustomers.CurrentRow.Cells["Nome/Razão Social"].Value.ToString();
                txtInscricaoE.Text = gridCustomers.CurrentRow.Cells["Insc. Estadual"].Value.ToString();
                txtInscricaoM.Text = gridCustomers.CurrentRow.Cells["Insc. Municipal"].Value.ToString();
                txtPais.Text = gridCustomers.CurrentRow.Cells["País"].Value.ToString();
                cboUf.SelectedIndex = cboUf.FindString(gridCustomers.CurrentRow.Cells["UF"].Value.ToString());
                txtCidade.Text = gridCustomers.CurrentRow.Cells["Município"].Value.ToString();
                txtBairro.Text = gridCustomers.CurrentRow.Cells["Bairro"].Value.ToString();
                txtEndereco.Text = gridCustomers.CurrentRow.Cells["Endereço"].Value.ToString();
                txtCep.Text = gridCustomers.CurrentRow.Cells["CEP"].Value.ToString();
            }
          
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            if (gridCustomers.SelectedRows.Count != 1)
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
                cliente.Deletar(gridCustomers.CurrentRow.Cells["CPF/CNPJ"].Value.ToString());
                LoadTable();
            }
            if (gridCustomers.Rows.Count == 0) { btnEditar.Enabled = false; btnExcluir.Enabled = false; }
        }   

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (!TudoVazio())
            {
                DialogResult resposta = MessageBox.Show(this, "Deseja descartar as alterações pendentes?", "Alerta",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.None,
                                        MessageBoxDefaultButton.Button2);

                if (resposta == DialogResult.No) return;
            }

            LimparCampos();
        }

        private void gridCustomers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnEditar_Click(sender, e);
        }

        private void TextChanged(object sender, EventArgs e)
        {
            if (TudoPreenchido()) btnCadastrar.Enabled = true;
            else btnCadastrar.Enabled = false;
        }
        //--------------------------------------------

        //------VALIDAÇÕES
        private void txtCnpjCpf_Validating(object sender, CancelEventArgs e)
        {
            string CnpjCpf;

            if (txtCnpjCpf.Text.Length == 0) return;

            CnpjCpf = txtCnpjCpf.Text.Trim();
            CnpjCpf = CnpjCpf.Replace(".", "").Replace("-", "").Replace("/", "");

            txtCnpjCpf.SelectionStart = 0;
            txtCnpjCpf.SelectionLength = txtCnpjCpf.TextLength;

            if (CnpjCpf.Length == 14)
            {
                if (!Validacao.ValidaCnpj(CnpjCpf))
                {
                    MessageBox.Show(this, "Cnpj inválido!", "Dado inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Cancel = true;
                    return;
                }
                txtCnpjCpf.Text = string.Concat(CnpjCpf.Substring(0, 2) + ".",
                                                CnpjCpf.Substring(2, 3), ".",
                                                CnpjCpf.Substring(5, 3), "/",
                                                CnpjCpf.Substring(8, 4), "-",
                                                CnpjCpf.Substring(12));
                return;
            }

            if (CnpjCpf.Length == 11)
            {
                if (!Validacao.ValidaCpf(CnpjCpf))
                {
                    MessageBox.Show(this, "Cpf inválido!", "Dado inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Cancel = true;
                    return;
                }
                txtCnpjCpf.Text = string.Concat(CnpjCpf.Substring(0, 3) + ".",
                                                CnpjCpf.Substring(3, 3), ".",
                                                CnpjCpf.Substring(6, 3), "-",
                                                CnpjCpf.Substring(9));
                return;
            }

            MessageBox.Show(this, "Cnpj ou Cpf inválido!", "Dado inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            e.Cancel = true;
        }
        private void txtInscricaoE_Validating(object sender, CancelEventArgs e)
        {
            if (Validacao.IsPositiveInteger(txtInscricaoE.Text) || txtInscricaoE.Text == "") e.Cancel = false;
            else { e.Cancel = true; MessageBox.Show("Valor inválido", "Erro"); }
        }
        private void txtInscricaoM_Validating(object sender, CancelEventArgs e)
        {
            if (Validacao.IsPositiveInteger(txtInscricaoM.Text) || txtInscricaoM.Text == "") e.Cancel = false;
            else { e.Cancel = true; MessageBox.Show("Valor inválido", "Erro"); }
        }
        private void txtCep_Validating(object sender, CancelEventArgs e)
        {
            if (Validacao.IsPositiveInteger(txtCep.Text) && txtCep.Text.Length == 8 || txtCep.Text == "") e.Cancel = false;
            else { e.Cancel = true; MessageBox.Show("Valor inválido", "Erro"); }
        }
        //-------------------------------------------------

        //-----------------FUNÇÕES AUXILIARES
        private void LoadTable() {gridCustomers.DataSource = cliente.Consulta();}

        private void LimparCampos()
        {
            if (txtCnpjCpf.Enabled) txtCnpjCpf.Text = "";
            txtRazaoSocial.Text = "";
            txtInscricaoE.Text = "";
            txtInscricaoM.Text = "";
            txtPais.Text = "Brasil";
            cboUf.SelectedIndex = -1;
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtEndereco.Text = "";
            txtCep.Text = "";
        }

        private bool TudoPreenchido()
        {
            return txtCnpjCpf.Text.Length != 0 && txtRazaoSocial.Text.Length != 0 && txtInscricaoE.Text.Length != 0 &&
                txtInscricaoM.Text.Length != 0 && txtPais.Text.Length != 0 && cboUf.Text.Length != 0 &&
                txtCidade.Text.Length != 0 && txtBairro.Text.Length != 0 && txtEndereco.Text.Length != 0 &&
                txtCep.Text.Length != 0;
        }

        private bool TudoVazio()
        {
            return txtCnpjCpf.Text.Length == 0 && txtRazaoSocial.Text.Length == 0 && txtInscricaoE.Text.Length == 0 &&
                txtInscricaoM.Text.Length == 0 && (txtPais.Text.Length == 0 || txtPais.Text == "Brasil") && cboUf.Text.Length == 0 &&
                txtCidade.Text.Length == 0 && txtBairro.Text.Length == 0 && txtEndereco.Text.Length == 0 &&
                txtCep.Text.Length == 0;
        }

    }
}
