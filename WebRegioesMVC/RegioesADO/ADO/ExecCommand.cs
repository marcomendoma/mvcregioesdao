using System;
using System.Data;
using System.Data.SqlClient;

namespace RegioesADO.ADO
{
    public class ExecCommand
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCommand = new SqlCommand();
        private SqlDataReader sqlDataReader;

        public ExecCommand(SqlConnection con)
        {
            this.sqlCon = con;    
        }

        public SqlDataReader ExecProcedure(string sProcedure, long lValor)
        {
            try
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = sProcedure;
                //sqlCommand.Parameters.Add("id_fornecedor", SqlDbType.Int);
                sqlCommand.Parameters.AddWithValue("id_fornecedor", lValor);
                sqlCommand.Connection = sqlCon;

                sqlDataReader = sqlCommand.ExecuteReader(); 
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return sqlDataReader;
        }

        public void ExecutaCommando(string sCommnad)
        {
            try
            {
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = sCommnad;
                sqlCommand.Connection = sqlCon;

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString()); 
            }
        }
    }
}
