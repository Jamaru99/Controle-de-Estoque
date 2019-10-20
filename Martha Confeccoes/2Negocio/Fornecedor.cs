using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Martha_Confeccoes._3Dados;

namespace Martha_Confeccoes._2Negocio
{
    class Fornecedor
    {
        AcessoBD bd = new AcessoBD();

        private string cnpj;
        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value;  }
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
            string query = "INSERT INTO Fornecedor VALUES('" +
                            cnpj + "', '" + razao_social + "', '" + inscricao_estadual + "', '" +
                            inscricao_municipal + "', '" + endereco + "', '" + bairro + "', '" +
                            municipio + "', '" + uf + "', '" + pais + "', '" +
                            cep + "');";
            bd.ExecutarComandoSQL(query);
        }

        public void Deletar(string cpfCnpj)
        {
            string query = "DELETE FROM Fornecedor WHERE cnpj = '" + cpfCnpj + "'";
            bd.ExecutarComandoSQL(query);
        }

        public void Alterar(string cnpj)
        {
            string query = "UPDATE Fornecedor SET razao_social = '" + razao_social + "', inscricao_estadual = '" + inscricao_estadual + "', " +
                            "inscricao_municipal = '" + inscricao_municipal + "', endereco = '" + endereco + "', bairro = '" + bairro + "', " +         
                            "uf = '" + uf + "', municipio = '" + municipio + "', cep = '" + cep + "' where cnpj = '" + cnpj + "';";
            bd.ExecutarComandoSQL(query);
        }

        public DataTable Consulta()
        {
            string query = string.Concat("SELECT ",
                                            "  cnpj AS [CNPJ]",
                                            ", razao_social AS [Razão Social]",
                                            ", inscricao_estadual AS [Insc. Estadual]",
                                            ", inscricao_municipal AS [Insc. Municipal]",
                                            ", endereco AS [Endereço]",
                                            ", bairro AS [Bairro]",
                                            ", municipio AS [Município]",
                                            ", uf AS [UF]",
                                            ", pais AS [País]",
                                            ", cep AS [CEP]",
                                            " FROM",
                                            " Fornecedor");
            return bd.Tabela(query);
        }
    }
}
