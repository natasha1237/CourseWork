namespace Figures.Logic
{
    using Figures.Entity_Data.Figures_Entities;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    public static class ReadFromDatabase
    {
        static SqlConnection conn;
        static SqlCommand cmd;
        static SqlDataReader dReader;

        public static List<Triangle> ReadAllTriangles(string connectionString)
        {
            List<Triangle> trs = new List<Triangle>();

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand("select * from Triangles", conn))
                    {
                        dReader = cmd.ExecuteReader();

                        while (dReader.Read())
                        {
                            Triangle triangle = new Triangle();
                            triangle.Id = int.Parse(dReader["Id"].ToString());
                            triangle.Name = dReader["Name"].ToString();
                            triangle.Type = dReader["Type"].ToString();
                            triangle.A = float.Parse(dReader["A"].ToString());
                            triangle.B = float.Parse(dReader["B"].ToString());
                            triangle.C = float.Parse(dReader["C"].ToString());
                            triangle.Areaa = float.Parse(dReader["Area"].ToString());
                            triangle.Perim = float.Parse(dReader["Perimeter"].ToString());
                            triangle.Tops = int.Parse(dReader["Tops"].ToString());
                            triangle.Edges = int.Parse(dReader["Edges"].ToString());

                            trs.Add(triangle);
                        }
                    }
                }
            }
            catch { }
            finally
            {
                dReader.Close();
                conn.Close();
            }

            return trs;
        }
    }
}
