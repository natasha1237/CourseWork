using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class DataBase : IDataBase
    {
        private SqlConnection connection;
        public SqlConnection GetConnection => connection;
        public DataBase(string serverName,string dbName)
        {
            connection = Connection.GetConnection(serverName, dbName);
        }
        public int Add(string command)
        {
            // insert into tablename(...) values(...)
            // select id from tablename where (...)=(...)
            throw new Exception();
        }

        public int Delete(string command)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
