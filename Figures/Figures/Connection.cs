using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Figures
{
    class Connection
    {
        private static SqlConnection connection;
        private SqlConnection sqlConnection
        {
            get
            {
                Connect();
                return connection;
            }
        }
        private string connectionString;
        public string ConnectionString => connectionString;
        public Connection(string serverName, string DBName)
        {
            connectionString = @"Data Source =" + serverName + ";Initial Catalog=" + DBName + ";Integrated Security=True";
        }
        private void Connect()
        {
            if (connection!= null)
            {
                return;
            }
            try
            {
                connection = new SqlConnection(connectionString);
                ConnectionOpen();
            }
            catch (SqlException e)
            {
                throw e;
            }

        }
        public void ConnectionOpen()
        {
            connection.Open();
        }
        /// <summary>
        /// 
        /// </summary>
        public void ConnectionClose()
        {
            connection.Close();
        }
        /// <summary>
        /// return SqlConnection to DB
        /// </summary>
        /// <returns>qwrqwef</returns>
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
        /// <summary>
        /// return SqlConnection to DB
        /// </summary>
        /// <param name="serverName"> name of SQL Server</param>
        /// <param name="DBName"> name of your Data Base</param>
        /// <returns></returns>
        public static SqlConnection GetConnection(string serverName, string DBName)
        {
            if (connection == null)
            {
                connection = new Connection(serverName, DBName).sqlConnection;
            }
            return connection;
        }
    }
}
