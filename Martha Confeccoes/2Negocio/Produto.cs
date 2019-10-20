using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Martha_Confeccoes._3Dados;

namespace Martha_Confeccoes._2Negocio
{
    class Produto
    {
        AcessoBD bd = new AcessoBD();

        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private string tamanho;
        public string Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }

        private string preco;
        public string Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        private int isPA;
        public int IsPA
        {
            get { return isPA; }
            set { isPA = value; }
        }

        public void Inserir()
        {
            string query = "INSERT INTO PRODUTO VALUES('" +
                            descricao + "', " + isPA + ", " + tamanho + ", " +
                            preco + ");";

            bd.ExecutarComandoSQL(query);
        }

        public void Alterar(string id)
        {
            string query = "UPDATE Produto SET Descricao = '" + descricao + "', Tamanho = " + tamanho + ", " +
                "Preco = " + preco + ", " + "MP_PA = " + isPA + " WHERE id = " + id;
            bd.ExecutarComandoSQL(query);
        }

        public void Deletar(string id)
        {
            try
            {
                string query = "DELETE FROM Produto WHERE Id = " + id;
                bd.ExecutarComandoSQL(query);
            }
            catch
            {
                string query = "DELETE FROM Estoque where produto_id = " + id + ";" +
                               "DELETE FROM Itens_pedido WHERE produto_id = " + id + ";" +
                               "DELETE FROM Produto WHERE Id = " + id;
                bd.ExecutarComandoSQL(query);
            }
        }

        public DataTable Consulta()
        {
            string query = "SELECT Id, Descricao, Tamanho, Preco, CASE WHEN MP_PA = 1 THEN 'Produto Final' " +
                "ELSE 'Matéria Prima' END AS Tipo FROM PRODUTO";
            return bd.Tabela(query);
        }

        public DataTable Consulta(string descricao, string precoMin, string precoMax, string tamanhoMin, string tamanhoMax, bool pa, bool mp)
        {
            if (pa == false && mp == false) return bd.Tabela("SELECT * FROM Produto WHERE MP_PA = 2");
            string where = "";
            if(descricao != "")
                where = " Descricao like '" + descricao + "%'";
            if (precoMin != "")
                where += (where != "" ? " AND " : "") + " Preco >= " + precoMin;
            if (precoMax != "")
                where += (where != "" ? " AND " : "") + " Preco <= " + precoMax;
            if (tamanhoMin != "")
                where += (where != "" ? " AND " : "") + " Tamanho >= " + tamanhoMin;
            if (tamanhoMax != "")
                where += (where != "" ? " AND " : "") + " Tamanho <= " + tamanhoMax;
            if(pa ^ mp)
            {
                if (pa) where += (where != "" ? " AND " : "") + " MP_PA = 1";
                if (mp) where += (where != "" ? " AND " : "") + " MP_PA = 0";
            }

            string query = "SELECT Id, Descricao, Tamanho, Preco, CASE WHEN MP_PA = 1 THEN 'Produto Final' " +
                "ELSE 'Matéria Prima' END AS Tipo FROM PRODUTO " + (where != "" ? " WHERE " : "") + where;
            return bd.Tabela(query);
        }
        
    }
}
