using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Martha_Confeccoes._3Dados;

namespace Martha_Confeccoes._2Negocio
{
    class Pedido
    {
        AcessoBD bd = new AcessoBD();

        private string cliente_cnpj_cpf;
        public string Cliente_cnpj_cpf
        {
            get { return cliente_cnpj_cpf; }
            set { cliente_cnpj_cpf = value; }
        }

        private string data_criacao;
        public string Data_criacao
        {
            get { return data_criacao; }
            set { data_criacao = value; }
        }

        private string data_entrega;
        public string Data_entrega
        {
            get { return data_entrega; }
            set { data_entrega = value; }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value;  }
        }

        public void Inserir()
        {
            string query = "INSERT INTO Pedido VALUES('" +
                            cliente_cnpj_cpf + "', " + data_criacao + ", " + data_entrega + ", '" + status + "');";
            bd.ExecutarComandoSQL(query);
        }

        public void Alterar(string id)
        {
            string query = "UPDATE Pedido SET cliente_cnpj_cpf = '" + cliente_cnpj_cpf + "', data_criacao = " + data_criacao +
                ", data_entrega = " + data_entrega + ", status = '" + status + "' WHERE id = " + id;
            bd.ExecutarComandoSQL(query);
        }

        public bool TodosFinalizados(string id)
        {
            string query = "SELECT id FROM itens_pedido where pedido_id = " + id + " AND [status] = 'Atendido'";
            DataTable tabelinha = bd.Tabela(query);
            if (tabelinha.Rows.Count < bd.GetInt("SELECT count(id) FROM Itens_pedido WHERE pedido_id = " + id, 0))
                return false;
            else return true;
        }

        public void Finalizar(int id)
        {
            string query = "UPDATE Pedido SET status = 'Finalizado' where id = " + id;
            bd.ExecutarComandoSQL(query);
            string queryEstoque = "DECLARE @id int;" +
                                  "DECLARE cursorItens CURSOR SCROLL FOR " +
                                  "SELECT id FROM Itens_pedido WHERE pedido_id = " + id +
                                  "OPEN cursorItens; FETCH FIRST FROM cursorItens INTO @id;" +
                                  "WHILE (@@FETCH_STATUS = 0) BEGIN " +
                                     "UPDATE Estoque SET [status] = 'Vendido' WHERE itens_pedido_id = @id;" + 
                                     "FETCH NEXT FROM cursorItens INTO @id; END " +
                                  "CLOSE cursorItens; DEALLOCATE cursorItens;";
            bd.ExecutarComandoSQL(queryEstoque);
        }

        public void Cancelar(string id)
        {
            string query = "UPDATE Pedido SET status = 'Cancelado' where id = " + id;
            bd.ExecutarComandoSQL(query);
            string queryEstoque = "DECLARE @id int;" +
                                  "DECLARE cursorItens CURSOR SCROLL FOR " +
                                  "SELECT id FROM Itens_pedido WHERE pedido_id = " + id +
                                  "OPEN cursorItens; FETCH FIRST FROM cursorItens INTO @id;" +
                                  "WHILE (@@FETCH_STATUS = 0) BEGIN " +
                                     "UPDATE Estoque SET [status] = 'Disponível' WHERE itens_pedido_id = @id;" +
                                     "UPDATE Ordem_producao SET [status] = 'Cancelada' WHERE itens_pedido_id = @id;" +
                                     "FETCH NEXT FROM cursorItens INTO @id; END " +
                                  "CLOSE cursorItens; DEALLOCATE cursorItens;";
            bd.ExecutarComandoSQL(queryEstoque);
        }

        public int GetMax()
        {
            string query = "SELECT MAX(id) FROM PEDIDO";
            return bd.GetInt(query, 0);
        }

        public DataTable Consulta()
        {
            string query = "SELECT Pedido.id AS 'ID', Cliente.razao_social AS 'Cliente', CONVERT(varchar, Pedido.data_criacao, 103) AS 'Criação', " +
                "CONVERT(varchar, Pedido.data_entrega, 103) AS 'Entrega', Pedido.status AS 'Status' FROM " +
                "Pedido INNER JOIN Cliente ON Pedido.cliente_cnpj_cpf = Cliente.cnpj_cpf";
            return bd.Tabela(query);
        }

        public DataTable Consulta(string filter, bool pendentes, bool finalizados, bool cancelados)
        {
            string query = "SELECT Pedido.id AS 'ID', Cliente.razao_social AS 'Cliente', CONVERT(varchar, Pedido.data_criacao, 103) AS 'Criação', " +
                "CONVERT(varchar, Pedido.data_entrega, 103) AS 'Entrega', Pedido.status AS 'Status' FROM " +
                "Pedido INNER JOIN Cliente ON Pedido.cliente_cnpj_cpf = Cliente.cnpj_cpf WHERE " +
                "(Cliente.razao_social like '" + filter + "%' OR Pedido.id like '" + filter + "%') AND (";
            /*
            if (dataInicio.Length == 0)
                query += " AND data_entrega >= '" + dataInicio + "'";
            if (dataFim.Length == 0)
                query += " AND data_entrega <= '" + dataFim + "'";*/
            if(!pendentes && !finalizados && !cancelados) { query += "status = 'inexistente')"; return bd.Tabela(query); }
            query += (pendentes ? "status = 'Pendente' OR " : "");
            query += (finalizados ? "status = 'Finalizado' OR " : "");
            query += (cancelados ? "status = 'Cancelado' OR " : "");
            query += "status = '')";
            return bd.Tabela(query);
        }

        public class Item
        {
            AcessoBD bd = new AcessoBD();

            private int idPedido;
            public int IdPedido
            {
                get { return idPedido; }
                set { idPedido = value; }
            }

            private int idProduto;
            public int IdProduto
            {
                get { return idProduto; }
                set { idProduto = value; }
            }


            private int qtdProduto;
            public int QtdProduto
            {
                get { return qtdProduto; }
                set { qtdProduto = value; }
            }

            private string status;
            public string Status
            {
                get { return status; }
                set { status = value; }
            }

            public int QuantidadeNoEstoque(int idProduto)
            {
                string query = "SELECT produto_id, quantidade FROM Estoque WHERE status = 'Disponível'";
                return bd.GetQuantidadeEstoque(query, idProduto);
            }

            public int GetMaxId()
            {
                string query = "SELECT MAX(id) FROM Itens_pedido";
                return bd.GetInt(query, 0);
            }
                        
            public void Inserir()
            {
                string query = "SELECT quantidade FROM Itens_pedido WHERE produto_id = " + idProduto + " AND pedido_id = " + idPedido;
                DataTable tabelinha = bd.Tabela(query);
                if (tabelinha.Rows.Count == 0)
                {
                    if (QuantidadeNoEstoque(idProduto) == qtdProduto)
                    {
                        status = "Atendido";
                        query = "INSERT INTO Itens_Pedido VALUES(" + idPedido + ", " + idProduto + ", " + qtdProduto + ", '" +
                        status + "'); ";
                        string selectEstoque = "SELECT TOP 1 id, itens_pedido_id FROM Estoque " +
                            "WHERE status = 'Disponível' AND produto_id = " + idProduto;
                        int getIdEstoque = bd.GetInt(selectEstoque, 0);
                        string queryEstoque = "UPDATE Estoque SET status = 'Reservado', itens_pedido_id = " +
                            GetMaxId() + " WHERE itens_pedido_id = " + bd.GetInt(selectEstoque, 1);
                        bd.ExecutarComandoSQL(query + queryEstoque);
                    }
                    else if(QuantidadeNoEstoque(idProduto) > qtdProduto)
                    {
                        status = "Atendido";
                        query = "INSERT INTO Itens_Pedido VALUES(" + idPedido + ", " + idProduto + ", " + qtdProduto + ", '" +
                        status + "'); ";
                        bd.ExecutarComandoSQL(query);

                        //Quebra o registro em 2
                        int qtd = QuantidadeNoEstoque(idProduto);
                        string selectEstoque = "SELECT TOP 1 id, itens_pedido_id FROM Estoque " +
                            "WHERE status = 'Disponível' AND produto_id = " + idProduto;
                        int getIdEstoque = bd.GetInt(selectEstoque,0);
                        string queryEstoque = "UPDATE Estoque SET status = 'Reservado', quantidade = " +
                            qtdProduto + ", itens_pedido_id = " + GetMaxId() + " WHERE id = " + getIdEstoque;
                        bd.ExecutarComandoSQL(queryEstoque);

                        int idLocal = bd.GetInt("SELECT locais_id FROM Estoque WHERE itens_pedido_id = " + GetMaxId(), 0);
                        queryEstoque = "INSERT INTO ESTOQUE VALUES(" + idLocal + ", " + bd.GetInt(selectEstoque,1) +
                            ", " + idProduto + ", 'Disponível', " + (qtd - qtdProduto) + ")";
                        bd.ExecutarComandoSQL(queryEstoque);                   
                    }
                    else
                    {
                        status = "Em produção";
                        query = "INSERT INTO Itens_Pedido VALUES(" + idPedido + ", " + idProduto + ", " + qtdProduto + ", '" +
                        status + "');";
                        bd.ExecutarComandoSQL(query);

                        string selectEstoque = "SELECT TOP 1 id, itens_pedido_id FROM Estoque " +
                            "WHERE status = 'Disponível' AND produto_id = " + idProduto;
                        int getIdEstoque = bd.GetInt(selectEstoque, 0);
                        string queryEstoque = "UPDATE Estoque SET status = 'Reservado'" +
                            " WHERE itens_pedido_id = " + getIdEstoque;
                        string queryProducao = "INSERT INTO Ordem_producao VALUES(" + GetMaxId() + ", " +
                            idProduto + ", 'Em produção'," + (qtdProduto - QuantidadeNoEstoque(idProduto)) + ");";
                        bd.ExecutarComandoSQL(queryEstoque + queryProducao);
                    }
                }
                else
                {
                    int id = bd.GetInt("SELECT id from Itens_pedido WHERE produto_id = " + idProduto + " AND " +
                        "pedido_id = " + idPedido, 0);
                    int qtdInicial = bd.GetInt(query, 0);
                    int qtdFinal = qtdProduto + qtdInicial;
                    if (QuantidadeNoEstoque(idProduto) >= qtdFinal) status = "Atendido";
                    else { status = "Em produção"; bd.ExecutarComandoSQL("DELETE FROM Estoque WHERE itens_pedido_id = " + id); }
                    query = "UPDATE Itens_Pedido SET quantidade = " + qtdFinal + ", status = '" + status + 
                        "' WHERE produto_id = " + idProduto + " AND pedido_id = " + idPedido;
                    
                    bd.ExecutarComandoSQL(query);
                    if (QuantidadeNoEstoque(idProduto) == qtdProduto)
                    {
                        string queryEstoque = "UPDATE Estoque SET status = 'Reservado', itens_pedido_id = " +
                            id + " WHERE status = 'Disponível' AND produto_id = " + idProduto;
                        bd.ExecutarComandoSQL(query + queryEstoque);
                    }
                    else if (QuantidadeNoEstoque(idProduto) > qtdProduto)
                    {
                        //Quebra o registro em 2
                        string queryEstoque, selectLocais = "SELECT locais_id FROM Estoque WHERE " +
                            "itens_pedido_id = " + id;
                        int idLocal = bd.GetInt(selectLocais, 0);
                        if(new Estoque().TemRepetido(id))
                        {
                            int qtd = bd.GetInt("SELECT quantidade FROM Estoque WHERE itens_pedido_id = " + id, 0);
                            queryEstoque = "UPDATE Estoque SET quantidade = " + (qtdProduto + qtd) +
                                                   " WHERE itens_pedido_id = " + id;
                        }
                        else
                        {
                            queryEstoque = "INSERT INTO Estoque VALUES(" + id + ", " +
                            idProduto + ", 'Em produção'," + (qtdProduto - QuantidadeNoEstoque(idProduto)) + ");";
                        }
                        bd.ExecutarComandoSQL(queryEstoque);
                        queryEstoque = "UPDATE Estoque SET status = 'Reservado', quantidade = " +
                            qtdProduto + ", itens_pedido_id = " + id + " WHERE status = 'Disponível' AND produto_id = " + idProduto;
                        bd.ExecutarComandoSQL(queryEstoque);

                    }
                    else
                    {
                        string queryProducao, queryEstoque = "UPDATE Estoque SET status = 'Reservado'" +
                            " WHERE status = 'Disponível' AND produto_id = " + idProduto + "; ";
                        if (new OrdemProducao().TemRepetido(id))
                        {
                            int qtd = bd.GetInt("SELECT quantidade FROM Ordem_producao WHERE itens_pedido_id = " + id, 0);
                            queryProducao = "UPDATE Ordem_producao SET quantidade = " + (qtdProduto + qtd) +
                                           ", status = 'Em produção' WHERE itens_pedido_id = " + id;
                        }
                        else
                        {
                            queryProducao = "INSERT INTO Ordem_producao VALUES(" + id + ", " +
                            idProduto + ", 'Em produção'," + (qtdProduto - QuantidadeNoEstoque(idProduto)) + ");";
                        }
                        bd.ExecutarComandoSQL(queryEstoque + queryProducao);
                    }

                }
            }

            public void Deletar(string id)
            {
                string query = "DELETE FROM Estoque WHERE itens_pedido_id = " + id + ";" +
                               "DELETE FROM Ordem_producao WHERE itens_pedido_id = " + id + ";" +
                               "DELETE FROM Itens_pedido WHERE id = " + id; 
                bd.ExecutarComandoSQL(query);
            }

            public DataTable Consulta(string pedidoId)
            {

                string query = "SELECT Itens_pedido.id, Produto.Descricao, Itens_pedido.quantidade, Itens_Pedido.status, Produto.Preco FROM " +
                    "Itens_pedido INNER JOIN Produto ON Itens_pedido.produto_id = Produto.Id where pedido_id = " + pedidoId;
                return bd.Tabela(query);
            }

        }
    }
}
