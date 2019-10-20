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
    public partial class Form_Producao : Form
    {
        OrdemProducao ordem = new OrdemProducao();

        public Form_Producao()
        {
            InitializeComponent();

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            ordem.Produto_id = gridProducao.CurrentRow.Cells["produto_id"].Value.ToString();
            ordem.Item_pedido_id = gridProducao.CurrentRow.Cells["itens_pedido_id"].Value.ToString();
            ordem.Local_id = (int)comboLocal.SelectedValue;
            ordem.Quantidade = Int32.Parse(gridProducao.CurrentRow.Cells["Quantidade"].Value.ToString());
            ordem.Finalizar(gridProducao.CurrentRow.Cells["id"].Value.ToString());
            LoadTable();
        }

        private void Form_Producao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'martinhaDataSet2.Locais'. Você pode movê-la ou removê-la conforme necessário.
            this.locaisTableAdapter.Fill(this.martinhaDataSet2.Locais);

            LoadTable();
            if (comboLocal.Text == "") btnFinalizar.Enabled = false; 

        }

        private void LoadTable()
        {
            gridProducao.DataSource = ordem.Consulta();
            gridProducao.Columns["id"].Visible = false;
            gridProducao.Columns["itens_pedido_id"].Visible = false;
            gridProducao.Columns["produto_id"].Visible = false;
        }
    }
}
