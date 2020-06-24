namespace Figures.UI
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using Figures.Logic;
    using FiguresApp.Figures_Entities;
    using System.Globalization;
    static class _3d_Figures
    {
        #region Fields:
        static Random rand = new Random();
        static string result = "";
        static string name, type;
        static double a, b, c, h, l, area, volume;
        static int tops, edges, sides, resultInt = 0, choice;
        #endregion

        #region 1 - Cube (Submenu)(Method):
        public static void TopicCube(DataBase db)
        {
            Console.Clear();
            Console.WriteLine("1 - Add new cube into the table:");
            Console.WriteLine("2 - Show all cubes from the table");
            Console.WriteLine("3 - Edit cube by Id");
            Console.WriteLine("4 - Delete cube by Id");
            Console.WriteLine("5 - Return back");
            Console.Write("\nPlease make your choice..");
            int choice1 = int.Parse(Console.ReadLine());
            switch (choice1)
            {
                case 1:
                    Console.Clear();
                    Cube cb = SetCube(out name, out type, out a, out area, out volume, out tops, out edges, out sides);
                    try
                    {
                        result = db.Add($"Insert into Cubes([Name],[Type],[A],[Volume],[Area],[Tops],[Edges],[Sides])" +
                            $"values('{name}','{type}','{a}','{volume}','{area}','{tops}','{edges}','{sides}')");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(result);
                        Console.ResetColor();
                        Pause();
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                        Pause();
                    }
                    break;
                case 2:
                    Console.Clear();
                    string conn = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                    List<Cube> list = ReadFiguresFromDB.ReadAllCubes(conn);
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(new string('-', 120));
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n{i + 1} Cube:\n");
                        Console.ForegroundColor = RandColors()[rand.Next(0, 5)];
                        Console.WriteLine(list[i]);
                        Console.ResetColor();
                        Console.WriteLine("\n" + new string('-', 120));
                    }
                    Pause();
                    break;
                case 3:
                    Console.Write("Enter any id of cube to Update: ");
                    int editId = int.Parse(Console.ReadLine());

                    Cube editCb = SetCube(out name, out type, out a, out area, out volume, out tops, out edges, out sides);
                    string editQuery = $"Update Cubes SET Name='{name}',Type='{type}',A='{a}', Volume='{volume}', Area='{area}' where Id={editId}";
                    try
                    {
                        resultInt = db.Update(editQuery);
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                        Pause();
                    }
                    if (resultInt == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nCube has updated successfull!!!");
                        Console.ResetColor();
                        Pause();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nThe method of Update() return {resultInt}\nSomething went wrong...Try to fix this!");
                        Console.ResetColor();
                        Pause();
                    }
                    break;
                case 4:
                    Console.Write("Enter any id of cube to Delete from the table: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    string delQuery = $"Delete from Cubes where Id={deleteId}";
                    try
                    {
                        resultInt = db.Delete(delQuery);
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                        Pause();
                    }
                    if (resultInt == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nCube has deleted successfully!!!");
                        Console.ResetColor();
                        Pause();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nThe method of Delete() return {result}\nSomething went wrong...Try to fix this!");
                        Console.ResetColor();
                        Pause();
                    }
                    break;
                case 5: break;
            }
        }
        #endregion

        #region 2 - Parallelepiped (Submenu)(Method):
        public static void TopicParallelepiped(DataBase db)
        {
            Console.Clear();
            Console.WriteLine("1 - Add new parallelepiped into the table:");
            Console.WriteLine("2 - Show all parallelepipeds from the table");
            Console.WriteLine("3 - Edit parallelepiped by Id");
            Console.WriteLine("4 - Delete parallelepiped by Id");
            Console.WriteLine("5 - Return back");
            Console.Write("\nPlease make your choice..");
            int choice1 = int.Parse(Console.ReadLine());
            switch (choice1)
            {
                case 1:
                    Console.Clear();
                    Parallelepiped prll = SetParallelepiped(out name, out type, out a, out b, out h, out area, out volume, out tops, out edges, out sides);
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        result = db.Add($"\n\nInsert into Parallelepipeds([Name],[Type],[A],[B],[H],[Volume],[Area],[Tops],[Edges],[Sides])" +
                            $"values('{name}','{type}','{a}','{b}','{h}','{volume}','{area}','{tops}','{edges}','{sides}')");
                        Console.WriteLine(result);
                        Console.ResetColor();
                        Pause();
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                        Pause();
                    }
                    break;
                case 2:
                    Console.Clear();
                    string conn = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                    List<Parallelepiped> list = ReadFiguresFromDB.ReadAllParallelepipeds(conn);
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(new string('-', 120));
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n{i + 1} Parallelepiped:\n");
                        Console.ForegroundColor = RandColors()[rand.Next(0, 5)];
                        Console.WriteLine(list[i]);
                        Console.ResetColor();
                        Console.WriteLine("\n" + new string('-', 120));
                    }
                    Pause();
                    break;
                case 3:
                    Console.Write("Enter any id of parallelepiped to Update: ");
                    int editId = int.Parse(Console.ReadLine());

                    Parallelepiped editPrll = SetParallelepiped(out name, out type, out a, out b, out h, out area, out volume, out tops, out edges, out sides);
                    string editQuery = $"Update Parallelepipeds SET Name='{name}',Type='{type}',A='{a}', B='{b}', H='{h}', Volume='{volume}', Area='{area}' where Id={editId}";
                    try
                    {
                        resultInt = db.Update(editQuery);
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                        Pause();
                    }
                    if (resultInt == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nParallelepiped has updated successfull!!!");
                        Console.ResetColor();
                        Pause();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nThe method of Update() return {resultInt}\nSomething went wrong...Try to fix this!");
                        Console.ResetColor();
                        Pause();
                    }
                    break;
                case 4:
                    Console.Write("Enter any id of parallelepiped to Delete from the table: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    string delQuery = $"Delete from Parallelepipeds where Id={deleteId}";
                    try
                    {
                        resultInt = db.Delete(delQuery);
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                        Pause();
                    }
                    if (resultInt == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nParallelepiped has deleted successfully!!!");
                        Console.ResetColor();
                        Pause();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nThe method of Delete() return {result}\nSomething went wrong...Try to fix this!");
                        Console.ResetColor();
                        Pause();
                    }
                    break;
                case 5: break;
            }
        }
        #endregion

        #region 3 - Prism (Submenu)(Method):
        public static void TopicPrism(DataBase db)
        {
            Console.Clear();
            Console.WriteLine("1 - Add new prism into the table:");
            Console.WriteLine("2 - Show all prisms from the table");
            Console.WriteLine("3 - Edit prism by Id");
            Console.WriteLine("4 - Delete prism by Id");
            Console.WriteLine("5 - Return back");
            Console.Write("\nPlease make your choice..");
            int choice1 = int.Parse(Console.ReadLine());
            switch (choice1)
            {
                case 1:
                    Console.Clear();
                    Prism prsm = SetPrism(out name, out type, out a, out b, out c, out h, out area, out volume, out tops, out edges, out sides);
                    try
                    {
                        result = db.Add($"Insert into Prisms([Name],[Type],[A],[B],[C],[H],[Volume],[Area],[Tops],[Edges],[Sides])" +
                            $"values('{name}','{type}','{a}','{b}','{c}','{h}','{volume}','{area}','{tops}','{edges}','{sides}')");

                        Console.ForegroundColor = (result == "Insert was Successful!Congratulations!!!") ? ConsoleColor.Green : ConsoleColor.Red;
                        Console.WriteLine(result);
                        Console.ResetColor();
                        Pause();
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                        Pause();
                    }
                    break;
                case 2:
                    Console.Clear();
                    string conn = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                    List<Prism> list = ReadFiguresFromDB.ReadAllPrisms(conn);
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(new string('-', 120));
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n{i + 1} Prism:\n");
                        Console.ForegroundColor = RandColors()[rand.Next(0, 5)];
                        Console.WriteLine(list[i]);
                        Console.ResetColor();
                        Console.WriteLine("\n" + new string('-', 120));
                    }
                    Pause();
                    break;
                case 3:
                    Console.Write("Enter any id of prism to Update: ");
                    int editId = int.Parse(Console.ReadLine());

                    Prism editPrsm = SetPrism(out name, out type, out a, out b, out c, out h, out area, out volume, out tops, out edges, out sides);
                    string editQuery = $"Update Prisms SET Name='{name}',Type='{type}',A='{a}', B='{b}', C='{c}', H='{h}', Volume='{volume}', Area='{area}' where Id={editId}";
                    try
                    {
                        resultInt = db.Update(editQuery);
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                        Pause();
                    }
                    if (resultInt == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nPrism has updated successfull!!!");
                        Console.ResetColor();
                        Pause();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nThe method of Update() return {resultInt}\nSomething went wrong...Try to fix this!");
                        Console.ResetColor();
                        Pause();
                    }
                    break;
                case 4:
                    Console.Write("Enter any id of prism to Delete from the table: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    string delQuery = $"Delete from Prisms where Id={deleteId}";
                    try
                    {
                        resultInt = db.Delete(delQuery);
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                        Pause();
                    }
                    if (resultInt == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nPrism has deleted successfully!!!");
                        Console.ResetColor();
                        Pause();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nThe method of Delete() return {result}\nSomething went wrong...Try to fix this!");
                        Console.ResetColor();
                        Pause();
                    }
                    break;
                case 5: break;
            }
        }
        #endregion

        #region 4 - Pyramid (Submenu)(Method):
        public static void TopicPyramid(DataBase db)
        {
            Console.Clear();
            Console.WriteLine("1 - Add new pyramid into the table:");
            Console.WriteLine("2 - Show all pyramids from the table");
            Console.WriteLine("3 - Edit pyramid by Id");
            Console.WriteLine("4 - Delete pyramid by Id");
            Console.WriteLine("5 - Return back");
            Console.Write("\nPlease make your choice..");
            int choice1 = int.Parse(Console.ReadLine());
            switch (choice1)
            {
                case 1:
                    Console.Clear();
                    Pyramid prmd = SetPyramid(out name, out type, out a, out b, out h, out l, out area, out volume, out tops, out edges, out sides);
                    try
                    {
                        result = db.Add($"Insert into Pyramids([Name], [Type], [A], [B], [H], [L], [Volume], [Area], [Sides], [Tops], [Edges])" +
                            $"values('{name}', '{type}', '{a}', '{b}', '{h}', '{l}', '{volume}', '{area}', '{sides}', '{tops}', '{edges}')");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(result);
                        Console.ResetColor();
                        Pause();
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                        Pause();
                    }
                    break;
                case 2:
                    Console.Clear();
                    string conn = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                    List<Pyramid> list = ReadFiguresFromDB.ReadAllPyramids(conn);
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(new string('-', 120));
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n{i + 1} Pyramid:\n");
                        Console.ForegroundColor = RandColors()[rand.Next(0, 5)];
                        Console.WriteLine(list[i]);
                        Console.ResetColor();
                        Console.WriteLine("\n" + new string('-', 120));
                    }
                    Pause();
                    break;
                case 3:
                    Console.Write("Enter any id of pyramid to Update: ");
                    int editId = int.Parse(Console.ReadLine());

                    Pyramid editPrmd = SetPyramid(out name, out type, out a, out b, out l, out h, out area, out volume, out tops, out edges, out sides);
                    string editQuery = $"Update Pyramids SET Name='{name}',Type='{type}',A='{a}', B='{b}', L='{l}', H='{h}', Volume='{volume}', Area='{area}' where Id={editId}";
                    try
                    {
                        resultInt = db.Update(editQuery);
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                        Pause();
                    }
                    if (resultInt == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nPyramid has updated successfull!!!");
                        Console.ResetColor();
                        Pause();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nThe method of Update() return {resultInt}\nSomething went wrong...Try to fix this!");
                        Console.ResetColor();
                        Pause();
                    }
                    break;
                case 4:
                    Console.Write("Enter any id of pyramid to Delete from the table: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    string delQuery = $"Delete from Pyramids where Id={deleteId}";
                    try
                    {
                        resultInt = db.Delete(delQuery);
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                        Pause();
                    }
                    if (resultInt == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nPyramid has deleted successfully!!!");
                        Console.ResetColor();
                        Pause();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nThe method of Delete() return {result}\nSomething went wrong...Try to fix this!");
                        Console.ResetColor();
                        Pause();
                    }
                    break;
                case 5: break;
            }
        }
        #endregion

        #region Set Cube (Method):
        public static Cube SetCube(out string name, out string type, out double a,
        out double area, out double volume, out int tops, out int edges, out int sides)
        {
            Console.Write("Set Name of Cube: ");
            name = Console.ReadLine();

            Console.Write("Set Type of Cube: ");
            type = Console.ReadLine();

            Console.Write("Enter one side of cube:\n");
            Console.Write("a: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Cube cube = new Cube(a);
            cube.Name = name;
            cube.Type = type;
            area = cube.Area();
            volume = cube.Volume();
            tops = cube.QuantityOfTops();
            edges = cube.QuantityOfEdges();
            sides = cube.QuantityOfSides();

            return cube;
        }
        #endregion

        #region Set Parallelepiped (Method):
        public static Parallelepiped SetParallelepiped(out string name, out string type, out double a, out double b,
        out double h, out double area, out double volume, out int tops, out int edges, out int sides)
        {
            Console.Write("Set Name of Parallelepiped: ");
            name = Console.ReadLine();

            Console.Write("Set Type of Parallelepiped: ");
            type = Console.ReadLine();

            Console.Write("Enter two sides of parallelepiped base and height:\n");
            Console.Write("a: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("b: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("h: ");
            h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Parallelepiped parallelepiped = new Parallelepiped(a, b, h);

            parallelepiped.Name = name;
            parallelepiped.Type = type;
            area = parallelepiped.Area();
            volume = parallelepiped.Volume();
            tops = parallelepiped.QuantityOfTops();
            edges = parallelepiped.QuantityOfEdges();
            sides = parallelepiped.QuantityOfSides();

            parallelepiped.Areaa = area;
            parallelepiped.Volumee = volume;

            return parallelepiped;
        }
        #endregion

        #region Set Prism (Method):
        public static Prism SetPrism(out string name, out string type, out double a, out double b, out double c,
        out double h, out double area, out double volume, out int tops, out int edges, out int sides)
        {
            Console.Write("Set Name of Prism: ");
            name = Console.ReadLine();

            Console.Write("Set Type of Prism: ");
            type = Console.ReadLine();

            Console.Write("Enter three sides of prism base and height:\n");
            Console.Write("a: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("b: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("c: ");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("h: ");
            h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Prism prism = new Prism(a, b, c, h);
            prism.Name = name;
            prism.Type = type;
            area = prism.Area();
            volume = prism.Volume();
            tops = prism.QuantityOfTops();
            edges = prism.QuantityOfEdges();
            sides = prism.QuantityOfSides();

            return prism;
        }
        #endregion

        #region Set Pyramid (Method):
        public static Pyramid SetPyramid(out string name, out string type, out double a, out double b, out double h,
        out double l, out double area, out double volume, out int tops, out int edges, out int sides)
        {
            Console.Write("Set Name of Pyramid: ");
            name = Console.ReadLine();

            Console.Write("Set Type of Pyramid: ");
            type = Console.ReadLine();

            Console.Write("Enter two sides of pyramid base, height and apophema:\n");
            Console.Write("a: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("b: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("h: ");
            h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("l: ");
            l = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Pyramid pyramid = new Pyramid();
            pyramid.A = a;
            pyramid.B = b;
            pyramid.L = l;
            pyramid.H = h;
            pyramid.Name = name;
            pyramid.Type = type;
            area = pyramid.Area();
            volume = pyramid.Volume();
            tops = pyramid.QuantityOfTops();
            edges = pyramid.QuantityOfEdges();
            sides = pyramid.QuantityOfSides();

            return pyramid;
        }
        #endregion

        #region Pause (Method):
        static void Pause()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n\t\t\t\t\t\tPress any key to continue...");
            Console.ReadKey(true);
            Console.ResetColor();
        }
        #endregion

        #region Color generator (Method):
        static ConsoleColor[] RandColors()
        {
            return new ConsoleColor[]
            {
                ConsoleColor.Red,
                ConsoleColor.Green,
                ConsoleColor.Yellow,
                ConsoleColor.Blue,
                ConsoleColor.Cyan,
                ConsoleColor.DarkBlue
            };
        }
        #endregion
    }
}
