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
        string strConnection = "Data Source=LAPTOP-KA8EG4PV\\MSSQLSERVER05;Initial Catalog=QLRapChieuPhim;Integrated Security=True;";
        SqlConnection sqlConnect = null;
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

        // Hàm để thực hiện truy vấn trả về một cột duy nhất
        public string selectColumn(string columnName)
        {
            OpenConnection();
            sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlConnect;
            sqlcmd.CommandText = columnName;

            return Convert.ToString(sqlcmd.ExecuteScalar());
            //Sử dụng ExecuteScalar() để trả về giá trị của cột đầu tiên trong kết quả truy vấn
            CloseConnection();
        }

        // Hàm thực thi thủ tục 
        public void ExecuteStoredProcedure(string storedProcedureName, SqlParameter[] parameters)
        {
            OpenConnection();
            using (SqlCommand command = new SqlCommand(storedProcedureName, sqlConnect))
            {
                command.CommandType = CommandType.StoredProcedure;  // Đặt loại lệnh là Stored Procedure
                command.Parameters.AddRange(parameters);  // Thêm tham số vào thủ tục
                command.ExecuteNonQuery();  // Thực thi không trả về dữ liệu
            }
            CloseConnection();
        }
    }
}
