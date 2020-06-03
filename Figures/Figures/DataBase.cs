using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace Figures
{
    class DataBase : IDataBase
    {
        private SqlConnection connection;
        public SqlConnection GetConnection => connection;

        SqlConnection IDataBase.GetConnection => throw new NotImplementedException();

        public DataBase(string serverName, string dbName)
        {
            connection = Connection.GetConnection(serverName, dbName);
        }
        public int Add(string command)
        {
            DataTable dt = Select(command + ";\nselect SCOPE_IDENTITY()").Tables[0];
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0].ItemArray[0]);
            }
            else
            {
                return -1;
            }

        }

        public int Delete(string command)
        {
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            int number = sqlCommand.ExecuteNonQuery();
            return number;
        }

        public DataSet Select(string command)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(command, connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            adapter.Dispose();
            return dataSet;
        }

        public int Update(string command)
        {
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            int number = sqlCommand.ExecuteNonQuery();
            return number;
        }
    }
}
