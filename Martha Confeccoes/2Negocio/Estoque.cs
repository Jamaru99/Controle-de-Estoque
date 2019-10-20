using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Martha_Confeccoes._3Dados;
using System.Data;

namespace Martha_Confeccoes._2Negocio
{
    class Estoque
    {
        AcessoBD bd = new AcessoBD();

        private int locais_id;
        public int Locais_id
        {
            get { return locais_id; }
            set { locais_id = value; }
        }

        private int produto_id;
        public int Produto_id
        {
            get { return produto_id; }
            set { produto_id = value; }
        }

        private int quantidade;
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public void Inserir()
        {
            string query = "SELECT quantidade FROM ESTOQUE WHERE produto_id = " + produto_id + " AND locais_id = " + locais_id;
            DataTable tabelinha = bd.Tabela(query);
            if(tabelinha.Rows.Count == 0)
                query = "INSERT INTO Estoque VALUES(" + locais_id + ", 1, " + produto_id + ", 'Disponível', " + quantidade + ")";
            else
            {
                int x = bd.GetInt(query, 0);
                quantidade += x;
                query = "UPDATE Estoque SET quantidade = " + quantidade + " WHERE produto_id = " + produto_id + " AND " +
                    "locais_id = " + locais_id;
            }
            bd.ExecutarComandoSQL(query);
        }

        public DataTable Consulta(int locaisId, bool disponiveis, bool reservados, bool vendidos)
        {
            string query = "SELECT est.id, pedido.id Pedido, produto.Descricao Produto, est.quantidade Quantidade, est.status Status " +
                            "FROM Estoque AS est " +
                            "INNER JOIN Itens_pedido iten ON  iten.id = est.itens_pedido_id " +
                            "INNER JOIN Pedido pedido ON pedido.id = iten.pedido_id " +
                            "INNER JOIN Produto produto ON produto.id = est.produto_id WHERE locais_id = " + locaisId + " AND (";
            if (!disponiveis && !reservados && !vendidos) { query += "est.status = 'inexistente')"; return bd.Tabela(query); }
            query += (disponiveis ? "est.status = 'Disponível' OR " : "");
            query += (reservados ? "est.status = 'Reservado' OR " : "");
            query += (vendidos ? "est.status = 'Vendido' OR " : "");
            query += "est.status = '')";
            return bd.Tabela(query);
        }

        public bool TemProduto(int idLocais)
        {
            return bd.GetInt("SELECT count(id) FROM Estoque WHERE locais_id = " + idLocais, 0) > 0;
        }

        public bool TemRepetido(int idItemPedido)
        {
            string query = "SELECT id FROM Estoque WHERE itens_pedido_id = " + idItemPedido;
            DataTable tabelinha = bd.Tabela(query);
            if (tabelinha.Rows.Count == 0)
                return false;
            else
            {
                return true;
            }
        }
    }
}
