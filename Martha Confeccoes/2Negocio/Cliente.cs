using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Martha_Confeccoes._3Dados;
using Martha_Confeccoes._1Apresentacao;

namespace Martha_Confeccoes._2Negocio
{
    class Cliente
    {
        AcessoBD bd = new AcessoBD();

        private string cnpj_cpf;
        public string Cnpj_cpf
        {
            get { return cnpj_cpf; }
            set { cnpj_cpf = value; }
        }

        private string razao_social;
        public string Razao_social
        {
            get { return razao_social; }
            set { razao_social = value; }
        }

        private string inscricao_estadual;
        public string Inscricao_estadual
        {
            get { return inscricao_estadual; }
            set { inscricao_estadual = value; }
        }

        private string inscricao_municipal;
        public string Inscricao_municipal
        {
            get { return inscricao_municipal; }
            set { inscricao_municipal = value; }
        }

        private string endereco;
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private string bairro;
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        private string municipio;
        public string Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }

        private string uf;
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        private string pais;
        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        private string cep;
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        

        public void Inserir()
        {
            if (!Validacao.ExistPK("cnpj_cpf", "Cliente", cnpj_cpf))
            {
                string query = "INSERT INTO CLIENTE VALUES('" +
                                cnpj_cpf + "', '" + razao_social + "', '" + inscricao_estadual + "', '" +
                                inscricao_municipal + "', '" + endereco + "', '" + bairro + "', '" +
                                municipio + "', '" + uf + "', '" + pais + "', '" +
                                cep + "');";
                bd.ExecutarComandoSQL(query);
                MessageBox.Show("Cliente cadastrado!", "Sucesso");
            }
            else MessageBox.Show("CNPJ/CPF já existente", "Erro");
        }

        public void Deletar(string cpfCnpj) 
        {
            try
            {
                string query = "DELETE FROM CLIENTE WHERE cnpj_cpf = '" + cpfCnpj + "'";
                bd.ExecutarComandoSQL(query);
            }
            catch
            {
                string query = "DELETE ip FROM Itens_pedido ip INNER JOIN Pedido p ON ip.pedido_id = p.id " +
                                    "WHERE p.cliente_cnpj_cpf = '" + cpfCnpj + "';" +
                               "DELETE FROM Pedido WHERE cliente_cnpj_cpf = '" + cpfCnpj + "';" + 
                               "DELETE FROM CLIENTE WHERE cnpj_cpf = '" + cpfCnpj + "'";
                bd.ExecutarComandoSQL(query);
            }
        }

        
        public void Alterar(string cpfCnpj)
        {
            string query = "UPDATE Cliente SET razao_social = '" + razao_social + "', inscricao_estadual = '" + inscricao_estadual + "', " +
                            "inscricao_municipal = '" + inscricao_municipal + "', endereco = '" + endereco + "', bairro = '" + bairro + "', " +
                            "uf = '" + uf + "', municipio = '" + municipio + "', cep = '" + cep + "' where cnpj_cpf = '" + cpfCnpj + "';";
            bd.ExecutarComandoSQL(query);
        }
        

        public DataTable Consulta()
        {
            string query = string.Concat("SELECT ",
                                            "  cnpj_cpf AS [CPF/CNPJ]",
                                            ", razao_social AS [Nome/Razão Social]",
                                            ", inscricao_estadual AS [Insc. Estadual]",
                                            ", inscricao_municipal AS [Insc. Municipal]",
                                            ", endereco AS [Endereço]",
                                            ", bairro AS [Bairro]",
                                            ", municipio AS [Município]",
                                            ", uf AS [UF]",
                                            ", pais AS [País]",
                                            ", cep AS [CEP]",
                                            " FROM",
                                            " CLIENTE");
            return bd.Tabela(query);
        }
    }
}
