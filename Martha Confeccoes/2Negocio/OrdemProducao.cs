using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Martha_Confeccoes._3Dados;

namespace Martha_Confeccoes._2Negocio
{
    class OrdemProducao
    {
        AcessoBD bd = new AcessoBD();

        private string produto_id;
        public string Produto_id
        {
            get { return produto_id; }
            set { produto_id = value; }
        }

        private string item_pedido_id;
        public string Item_pedido_id
        {
            get { return item_pedido_id; }
            set { item_pedido_id = value; }
        }

        public int local_id;
        public int Local_id
        {
            get { return local_id; }
            set { local_id = value; }
        }

        private int quantidade;
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public DataTable Consulta()
        {
            string query = "SELECT ordem.id, ordem.produto_id, ordem.itens_pedido_id, pedido.id Pedido, produto.Descricao Produto, ordem.quantidade Quantidade, ordem.status Status " +
                            "FROM Ordem_producao AS ordem " +
                            "INNER JOIN Itens_pedido iten ON  iten.id = ordem.itens_pedido_id " +
                            "INNER JOIN Pedido pedido ON pedido.id = iten.pedido_id " +
                            "INNER JOIN Produto produto ON produto.id = ordem.produto_id;";
            return bd.Tabela(query);
        }

        public void Finalizar(string id)
        {
            string queryEstoque;
            if (new Estoque().TemRepetido(Int32.Parse(item_pedido_id)))
            {
                int qtd = bd.GetInt("SELECT quantidade FROM Estoque WHERE itens_pedido_id = " + item_pedido_id, 0);
                queryEstoque = "UPDATE Estoque SET quantidade = " + (quantidade + qtd) +
                                       " WHERE itens_pedido_id = " + item_pedido_id;
            }
            else
            {
                queryEstoque = "INSERT INTO Estoque VALUES(" + local_id + ", " + item_pedido_id + ", " + produto_id +
                ", 'Reservado', " + quantidade + ");";
            }
            string queryItemPedido = "UPDATE Itens_Pedido SET status = 'Atendido' WHERE id = " + item_pedido_id + ";";
            string query = "UPDATE Ordem_producao SET status = 'Finalizada' WHERE id = " + id + ";";
            bd.ExecutarComandoSQL(queryEstoque + queryItemPedido + query);
        }

        public bool TemRepetido(int idItemPedido)
        {
            string query = "SELECT id FROM Ordem_producao WHERE itens_pedido_id = " + idItemPedido;
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
