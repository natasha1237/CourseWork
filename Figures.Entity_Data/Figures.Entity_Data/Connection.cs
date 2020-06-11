namespace Figures.Entity_Data
{
    using System.Data.SqlClient;

    public class Connection
    {
        string connectionString;
        static SqlConnection connection;

        SqlConnection sqlConnection
        {
            get
            {
                Connect();
                return connection;
            }
        }

        /// <summary>
        /// string for connection to Data Base
        /// </summary>
        public string ConnectionString => connectionString;

        /// <summary>
        /// Create new connection class
        /// </summary>
        /// <param name="serverName">name of SQL server</param>
        /// <param name="DBName">name of Data base</param>
        public Connection(string serverName, string DBName) => connectionString = @"Data Source =" + serverName + ";Initial Catalog=" + DBName + ";Integrated Security=True";
     
        private void Connect()
        {
            if (connection != null) return;
            try
            {
                connection = new SqlConnection(connectionString);
                ConnectionOpen();
            }
            catch (SqlException e) { throw e; }
        }

        /// <summary>
        /// Open Sql connection
        /// </summary>
        public void ConnectionOpen() => connection.Open();

        /// <summary>
        /// Close this SQL connection
        /// </summary>
        public void ConnectionClose() => connection.Close();

        /// <summary>
        ///  return SqlConnection to DB
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection() => sqlConnection;

        /// <summary>
        /// Create and return new SqlConnection to DB or return existed SqlConnection
        /// </summary>
        /// <param name="serverName"> name of SQL Server</param>
        /// <param name="DBName"> name of your Data Base</param>
        /// <returns>SqlConnection to DB</returns>
        public static SqlConnection GetConnection(string serverName, string DBName)
        {
            if (connection == null) connection = new Connection(serverName, DBName).sqlConnection;

            return connection;
        }
    }
}
