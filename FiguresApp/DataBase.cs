namespace FiguresApp.Figures_Entities
{
    using Figures.EntityData;
    using FiguresApp.Figures_Interfaces;
    using System.Data;
    using System.Data.SqlClient;

    public class DataBase : IDataBase
    {
        SqlConnection connection;

        SqlConnection IDataBase.GetConnection => connection;

        public DataBase(string serverName, string dbName)
        {
            connection = Connection.GetConnection(serverName, dbName);
        }

        public virtual string Add(string command)
        {
            string msg = string.Empty;
            SqlCommand cmd = new SqlCommand(command, connection);
            int res = cmd.ExecuteNonQuery();
            if (res == 0)
                msg = "..Insert has been failed..Something went wrong...";
            else
                msg = "Insert was Successfully!Congratulation!!!";
            return msg;
            //DataTable dt = Select(command + ";\nselect SCOPE_IDENTITY()").Tables[0];
            //if (dt.Rows.Count > 0)
            //    return Convert.ToInt32(dt.Rows[0].ItemArray[0]);
            //else return -1;
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
