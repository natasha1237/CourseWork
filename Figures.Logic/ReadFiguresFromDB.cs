namespace Figures.Logic
{
    using System.Data.SqlClient;
    using System.Collections.Generic;
    using FiguresApp.Figures_Entities;

    public static class ReadFiguresFromDB
    {
        #region Ado .Net Objects:
        static SqlConnection conn;
        static SqlCommand cmd;
        static SqlDataReader dReader;
        #endregion

        #region All Triangles:
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
                            triangle.A = double.Parse(dReader["A"].ToString());
                            triangle.B = double.Parse(dReader["B"].ToString());
                            triangle.C = double.Parse(dReader["C"].ToString());
                            triangle.Areaa = double.Parse(dReader["Area"].ToString());
                            triangle.Perim = double.Parse(dReader["Perimeter"].ToString());
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
        #endregion

        #region All Trapezes:
        public static List<Trapeze> ReadAllTrapezes(string connectionString)
        {
            List<Trapeze> trz = new List<Trapeze>();

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand("select * from Trapezes", conn))
                    {
                        dReader = cmd.ExecuteReader();

                        while (dReader.Read())
                        {
                            Trapeze trapeze = new Trapeze();
                            trapeze.Id = int.Parse(dReader["Id"].ToString());
                            trapeze.Name = dReader["Name"].ToString();
                            trapeze.Type = dReader["Type"].ToString();
                            trapeze.A = double.Parse(dReader["A"].ToString());
                            trapeze.B = double.Parse(dReader["B"].ToString());
                            trapeze.C = double.Parse(dReader["C"].ToString());
                            trapeze.D = double.Parse(dReader["D"].ToString());
                            trapeze.H = double.Parse(dReader["h"].ToString());
                            trapeze.Areaa = double.Parse(dReader["Area"].ToString());
                            trapeze.Perim = double.Parse(dReader["Perimeter"].ToString());
                            trapeze.Tops = int.Parse(dReader["Tops"].ToString());
                            trapeze.Edges = int.Parse(dReader["Edges"].ToString());

                            trz.Add(trapeze);
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
            return trz;
        }
        #endregion

        #region All Squares:
        public static List<Square> ReadAllSquares(string connectionString)
        {
            List<Square> sq = new List<Square>();

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand("select * from Squares", conn))
                    {
                        dReader = cmd.ExecuteReader();

                        while (dReader.Read())
                        {
                            Square square = new Square();
                            square.Id = int.Parse(dReader["Id"].ToString());
                            square.Name = dReader["Name"].ToString();
                            square.Type = dReader["Type"].ToString();
                            square.A = double.Parse(dReader["A"].ToString());
                            square.Areaa = double.Parse(dReader["Area"].ToString());
                            square.Perim = double.Parse(dReader["Perimeter"].ToString());
                            square.Tops = int.Parse(dReader["Tops"].ToString());
                            square.Edges = int.Parse(dReader["Edges"].ToString());

                            sq.Add(square);
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
            return sq;
        }
        #endregion

        #region All Rhombs:
        public static List<Rhomb> ReadAllRhombs(string connectionString)
        {
            List<Rhomb> rhm = new List<Rhomb>();

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand("select * from Rhombs", conn))
                    {
                        dReader = cmd.ExecuteReader();

                        while (dReader.Read())
                        {
                            Rhomb rhomb = new Rhomb();
                            rhomb.Id = int.Parse(dReader["Id"].ToString());
                            rhomb.Name = dReader["Name"].ToString();
                            rhomb.Type = dReader["Type"].ToString();
                            rhomb.A = double.Parse(dReader["A"].ToString());
                            rhomb.H = double.Parse(dReader["H"].ToString());
                            rhomb.Areaa = double.Parse(dReader["Area"].ToString());
                            rhomb.Perim = double.Parse(dReader["Perimeter"].ToString());
                            rhomb.Tops = int.Parse(dReader["Tops"].ToString());
                            rhomb.Edges = int.Parse(dReader["Edges"].ToString());

                            rhm.Add(rhomb);
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
            return rhm;
        }
        #endregion

        #region All Rectangles:
        public static List<Rectangle> ReadAllRectangles(string connectionString)
        {
            List<Rectangle> rct = new List<Rectangle>();

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand("select * from Rectangles", conn))
                    {
                        dReader = cmd.ExecuteReader();

                        while (dReader.Read())
                        {
                            Rectangle rectangle = new Rectangle();
                            rectangle.Id = int.Parse(dReader["Id"].ToString());
                            rectangle.Name = dReader["Name"].ToString();
                            rectangle.Type = dReader["Type"].ToString();
                            rectangle.A = double.Parse(dReader["A"].ToString());
                            rectangle.B = double.Parse(dReader["B"].ToString());
                            rectangle.Areaa = double.Parse(dReader["Area"].ToString());
                            rectangle.Perim = double.Parse(dReader["Perimeter"].ToString());
                            rectangle.Tops = int.Parse(dReader["Tops"].ToString());
                            rectangle.Edges = int.Parse(dReader["Edges"].ToString());

                            rct.Add(rectangle);
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
            return rct;
        }
        #endregion

        #region All Parallelograms:
        public static List<Parallelogram> ReadAllParallelograms(string connectionString)
        {
            List<Parallelogram> par = new List<Parallelogram>();

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand("select * from Parallelograms", conn))
                    {
                        dReader = cmd.ExecuteReader();

                        while (dReader.Read())
                        {
                            Parallelogram parallelogram = new Parallelogram();
                            parallelogram.Id = int.Parse(dReader["Id"].ToString());
                            parallelogram.Name = dReader["Name"].ToString();
                            parallelogram.Type = dReader["Type"].ToString();
                            parallelogram.A = double.Parse(dReader["A"].ToString());
                            parallelogram.B = double.Parse(dReader["B"].ToString());
                            parallelogram.H = double.Parse(dReader["H"].ToString());
                            parallelogram.Areaa = double.Parse(dReader["Area"].ToString());
                            parallelogram.Perim = double.Parse(dReader["Perimeter"].ToString());
                            parallelogram.Tops = int.Parse(dReader["Tops"].ToString());
                            parallelogram.Edges = int.Parse(dReader["Edges"].ToString());

                            par.Add(parallelogram);
                        }
                    }
                }
            }
            catch(System.Exception ex) { string s = ex.Message; }
            finally
            {
                dReader.Close();
                conn.Close();
            }
            return par;
        }
        #endregion

        #region All Cubes:
        public static List<Cube> ReadAllCubes(string connectionString)
        {
            List<Cube> cb = new List<Cube>();

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand("select * from Cubes", conn))
                    {
                        dReader = cmd.ExecuteReader();

                        while (dReader.Read())
                        {
                            Cube cube = new Cube();
                            cube.Id = int.Parse(dReader["Id"].ToString());
                            cube.Name = dReader["Name"].ToString();
                            cube.Type = dReader["Type"].ToString();
                            cube.A = double.Parse(dReader["A"].ToString());
                            cube.Volumee = double.Parse(dReader["Volume"].ToString());
                            cube.Areaa = double.Parse(dReader["Area"].ToString());
                            cube.Sides = System.Convert.ToInt32(dReader["Sides"].ToString());
                            cube.Tops = System.Convert.ToInt32(dReader["Tops"].ToString());
                            cube.Edges = System.Convert.ToInt32(dReader["Edges"].ToString());
                            cb.Add(cube);
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
            return cb;
        }
        #endregion

        #region All Parallelepipeds:
        public static List<Parallelepiped> ReadAllParallelepipeds(string connectionString)
        {
            List<Parallelepiped> prll = new List<Parallelepiped>();

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand("select * from Parallelepipeds", conn))
                    {
                        dReader = cmd.ExecuteReader();

                        while (dReader.Read())
                        {
                            Parallelepiped parallelepiped = new Parallelepiped();
                            parallelepiped.Id = int.Parse(dReader["Id"].ToString());
                            parallelepiped.Name = dReader["Name"].ToString();
                            parallelepiped.Type = dReader["Type"].ToString();
                            parallelepiped.A = double.Parse(dReader["A"].ToString());
                            parallelepiped.B = double.Parse(dReader["B"].ToString());
                            parallelepiped.H = double.Parse(dReader["H"].ToString());
                            parallelepiped.Volumee = double.Parse(dReader["Volume"].ToString());
                            parallelepiped.Areaa = double.Parse(dReader["Area"].ToString());
                            parallelepiped.Tops = int.Parse(dReader["Tops"].ToString());
                            parallelepiped.Edges = int.Parse(dReader["Edges"].ToString());
                            parallelepiped.Sides = int.Parse(dReader["Sides"].ToString());
                            prll.Add(parallelepiped);
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
            return prll;
        }
        #endregion

        #region All Prisms:
        public static List<Prism> ReadAllPrisms(string connectionString)
        {
            List<Prism> prsm = new List<Prism>();

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand("select * from Prisms", conn))
                    {
                        dReader = cmd.ExecuteReader();

                        while (dReader.Read())
                        {
                            Prism prism = new Prism();
                            prism.Id = int.Parse(dReader["Id"].ToString());
                            prism.Name = dReader["Name"].ToString();
                            prism.Type = dReader["Type"].ToString();
                            prism.A = double.Parse(dReader["A"].ToString());
                            prism.B = double.Parse(dReader["B"].ToString());
                            prism.C = double.Parse(dReader["C"].ToString());
                            prism.H = double.Parse(dReader["H"].ToString());
                            prism.Volumee = double.Parse(dReader["Volume"].ToString());
                            prism.Areaa = double.Parse(dReader["Area"].ToString());
                            prism.Tops = int.Parse(dReader["Tops"].ToString());
                            prism.Edges = int.Parse(dReader["Edges"].ToString());
                            prism.Sides = int.Parse(dReader["Sides"].ToString());
                            prsm.Add(prism);
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
            return prsm;
        }
        #endregion

        #region All Pyramids:
        public static List<Pyramid> ReadAllPyramids(string connectionString)
        {
            List<Pyramid> pyr = new List<Pyramid>();

            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand("select * from Pyramids", conn))
                    {
                        dReader = cmd.ExecuteReader();

                        while (dReader.Read())
                        {
                            Pyramid pyramid = new Pyramid();
                            pyramid.Id = int.Parse(dReader["Id"].ToString());
                            pyramid.Name = dReader["Name"].ToString();
                            pyramid.Type = dReader["Type"].ToString();
                            pyramid.A = double.Parse(dReader["A"].ToString());
                            pyramid.B = double.Parse(dReader["B"].ToString());
                            pyramid.H = double.Parse(dReader["H"].ToString());
                            pyramid.L = double.Parse(dReader["L"].ToString());
                            pyramid.Volumee = double.Parse(dReader["Volume"].ToString());
                            pyramid.Areaa = double.Parse(dReader["Area"].ToString());
                            pyramid.Tops = int.Parse(dReader["Tops"].ToString());
                            pyramid.Edges = int.Parse(dReader["Edges"].ToString());
                            pyramid.Sides = int.Parse(dReader["Sides"].ToString());
                            pyr.Add(pyramid);
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
            return pyr;
        }
        #endregion
    }
}
