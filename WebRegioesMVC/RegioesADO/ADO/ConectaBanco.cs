using System;
using System.Data.SqlClient;

namespace RegioesADO.ADO
{
    public class ConectaBanco
    {
        //Instalar via nuget console
        //Para a utilização do ADO com Sqlserver
        //Install-Package System.Data.SqlClient -Version 4.4.0

        private string strCon = "Data Source=.\\SQLEXPRESS2014;Initial Catalog=teste;Integrated Security=True";

        public SqlConnection RetornaCon()
        {
            SqlConnection oCon;

            try
            {
                oCon = new SqlConnection(strCon);
                oCon.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString() + " na rotina de conexão com o banco de dados.");
            }

            return oCon;
        }
    }
}
