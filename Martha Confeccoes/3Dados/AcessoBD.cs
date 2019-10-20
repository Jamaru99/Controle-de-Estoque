using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Martha_Confeccoes._3Dados
{
    class AcessoBD
    {
        private string connectionString;
        private SqlConnection connection;

        public AcessoBD()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Martha_Confeccoes.Properties.Settings.martinhaConnectionString"].ConnectionString;
        }

        public void ExecutarComandoSQL(string query)
        {
            using (connection = new SqlConnection(connectionString)) //o comando "using" fecha a conexão automaticamente
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                //SqlTransaction transaction = connection.BeginTransaction("Transaction");
                //command.Transaction = transaction;
                command.ExecuteScalar();
            }
        }

        public DataTable Tabela(string query)
        {
            using (connection = new SqlConnection(connectionString)) //o comando "using" fecha a conexão automaticamente
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {

                try { connection.Open(); } catch { MessageBox.Show("Aguarde...", "Erro inesperado"); }
                
                    
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                
                
            }
            
        }

        public string GetString(string query)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) return reader.GetString(0);
                else return "olaaa";
            }
        }

        public int GetInt(string query, int index)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) return reader.GetInt32(index);
                else return 0;
            }
        }

        public int GetQuantidadeEstoque(string query, int idProduto)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                int quant = 0;
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == idProduto) quant += reader.GetInt32(1);
                }
                return quant;
            }
        }

    }
}
