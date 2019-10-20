using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Martha_Confeccoes._3Dados;
using System.Data;

namespace Martha_Confeccoes._2Negocio
{
    class Locais
    {
        AcessoBD bd = new AcessoBD();

        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public void Inserir()
        {
            string query = "INSERT INTO Locais VALUES('" + descricao + "')";
            bd.ExecutarComandoSQL(query);
        }

        public void Deletar(int id)
        {
            
            string query = "DELETE FROM Locais WHERE id = " + id;
            bd.ExecutarComandoSQL(query);
        }

    }
}
