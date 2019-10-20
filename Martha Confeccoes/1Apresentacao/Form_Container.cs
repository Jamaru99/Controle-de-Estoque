using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martha_Confeccoes._1Apresentacao
{
    public partial class Form_Container : Form
    {
        public Form_Container()
        {
            InitializeComponent();
        }

        private void CarregarForm(Form form)
        {
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point((this.Width - form.Width) / 2, (this.Height - form.Height) / 2);
            form.Show();
        }

        private void produtosMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            CarregarForm(new Form_Produto());
        }

        private void pedidosMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            CarregarForm(new Form_Pedido());
        }

        private void clienteMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            CarregarForm(new Form_Cliente());
        }

        private void estoqueMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            CarregarForm(new Form_Estoque());
        }

        private void fornecedoresMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            CarregarForm(new Form_Fornecedor());
        }


        private void produçãoMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            CarregarForm(new Form_Producao());
        }
    }
}