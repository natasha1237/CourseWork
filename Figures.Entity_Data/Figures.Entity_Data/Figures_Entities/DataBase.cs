namespace Figures.Entity_Data
{
    using Figures.Entity_Data.Figures_Entities;
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class DataBase : IDataBase
    {
        SqlConnection connection;

        SqlConnection IDataBase.GetConnection => throw new NotImplementedException();

        public DataBase()
        {
            connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        }

        public virtual int Add(string n, string t, params float[] p) // "INSERT INTO TABLENAME(....) VALUES(11,22,33,44,55)"
        {
            Triangle tr = new Triangle
            {
                Name = n,
                Type = t,
                A = p[0],
                B = p[1],
                C = p[2],
                Ar = p[3],
                Perim = p[4],
                Tops = (int)p[5],
                Edges = (int)p[6],
            };

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
