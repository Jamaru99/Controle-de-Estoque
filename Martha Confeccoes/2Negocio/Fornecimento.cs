using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Martha_Confeccoes._3Dados;

namespace Martha_Confeccoes._2Negocio
{
    class Fornecimento
    {
        AcessoBD bd = new AcessoBD();

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string fornecedor_cnpj;
        public string Fornecedor_cnpj
        {
            get { return fornecedor_cnpj; }
            set { fornecedor_cnpj = value; }
        }

        private int produto_id;
        public int Produto_id
        {
            get { return produto_id; }
            set { produto_id = value; }
        }

        public void Inserir()
        {
            string query = "INSERT INTO Fornecimento VALUES(" + fornecedor_cnpj + ", " + produto_id + ")";
        }

        public DataTable ConsultaFornecedor(int produtoId)
        {
            string query = "SELECT Fornecedor.razao_social FROM Fornecimento INNER JOIN Fornecedor ON " +
                "Fornecimento.fornecedor_cnpj = Fornecedor.cnpj WHERE Fornecimento.produto_id = " + produtoId;
            return bd.Tabela(query);
        }
    }
}
