using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_RapChieuPhim.Database
{
    public class DatabaseAccess
    {
        string strConnection = "Data Source=DESKTOP-N7QM0NS\\MSSQLSERVER01;Initial Catalog=QLRapChieuPhim;Integrated Security=True;";
        SqlConnection sqlConnect= null; 
        SqlCommand sqlcmd = null;

        void OpenConnection()
        {
            sqlConnect = new SqlConnection(strConnection);
            if (sqlConnect.State != ConnectionState.Open)
            {
                sqlConnect.Open();
            }
        }
        void CloseConnection()
        {
            if (sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
        }
        public DataTable DataRead(string select)
        {
            DataTable dbtable = new DataTable();
            OpenConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select, sqlConnect);
            sqlDataAdapter.Fill(dbtable);
            CloseConnection();
            return dbtable;
        }
        public void DataChange(string sqlQuery)
        {
            OpenConnection();
            sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlConnect;
            sqlcmd.CommandText = sqlQuery;
            sqlcmd.ExecuteNonQuery();
            CloseConnection();
        }

        public string selectColumn(string columnName)
        {
            OpenConnection();
            sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlConnect;
            sqlcmd.CommandText = columnName;



            return Convert.ToString(sqlcmd.ExecuteScalar());
            CloseConnection();
        }

        public void ExecuteStoredProcedure(string storedProcedureName, SqlParameter[] parameters)
        {
            OpenConnection();
            using (SqlCommand command = new SqlCommand(storedProcedureName, sqlConnect))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }
    }
}
