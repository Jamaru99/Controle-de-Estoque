using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Martha_Confeccoes._3Dados;

namespace Martha_Confeccoes._1Apresentacao
{
    class Validacao
    {
        public static bool VoltaNoTempoNecessaria(string txt1, string txt2)
        {
            DateTime criation = new DateTime(Int32.Parse(txt1.Substring(6, 4)),
                Int32.Parse(txt1.Substring(3, 2)), Int32.Parse(txt1.Substring(0, 2)));
            DateTime delivery = new DateTime(Int32.Parse(txt2.Substring(6, 4)),
                Int32.Parse(txt2.Substring(3, 2)), Int32.Parse(txt2.Substring(0, 2)));
            if (DateTime.Compare(delivery, criation) < 0 || delivery < DateTime.Now) return true;
            else return false;
        }

        public static bool DataValida(string txt)
        {
            DateTime dTeste;
            bool bErro = false;

            try
            {
                dTeste = new DateTime(int.Parse(txt.Substring(6)), int.Parse(txt.Substring(3, 2)), int.Parse(txt.Substring(0, 2)));

                if (dTeste.ToString("dd/MM/yyyy") != txt)
                {
                    bErro = true;
                }
            }
            catch
            {
                bErro = true;
            }

            if (bErro == true)
            {
                return false;
            }
            return true;
        }

        public static bool IsDateTime(string txtDate)
        {
            DateTime tempDate;
            return DateTime.TryParse(txtDate, out tempDate);
        }

        public static bool IsDouble(string s)
        {
            try
            {
                double x = double.Parse(s);
                if (x > 0) return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsPositiveInteger(string s)
        {
            try
            {
                double x = Int64.Parse(s);
                if (x > 0) return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool ValidaCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        public static bool ValidaCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public static bool ExistPK(string campo, string tabela, string valor)
        {
            string query = "SELECT " + campo + " FROM " + tabela + " WHERE " + campo + " = '" + valor + "'";
            DataTable dataTable = new AcessoBD().Tabela(query);
            return dataTable.Rows.Count > 0;
        }
    }
}
