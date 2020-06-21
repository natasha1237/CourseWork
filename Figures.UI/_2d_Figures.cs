namespace Figures.UI
{
    using System;
    using Figures.Logic;
    using System.Configuration;
    using System.Collections.Generic;
    using FiguresApp.Figures_Entities;

    static class _2d_Figures
    {
        #region Fields:
        static Random rand = new Random();
        static string result = "";
        static string name, type;
        static float a, b, c, d, h, area, perim;
        static int tops, edges, resultInt = 0, choice;
        #endregion

        #region Main menu:
        public static int Main_Menu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(new string('-', 120));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2D Figures:");
            Console.WriteLine("1 - Triangle");
            Console.WriteLine("2 - Quadrangle(Square, Rectangle, Rhomb, Parallelogram, Trapeze)\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("3D Figures:");
            Console.WriteLine("3 - Cube");
            Console.WriteLine("4 - Pyramid");
            Console.WriteLine("5 - Prism");
            Console.WriteLine("6 - Parallelepiped");
            Console.WriteLine("0 - Exit");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n" + new string('-', 120));
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Choose any one of the Figures..");
            int choice = int.Parse(Console.ReadLine());
            Console.ResetColor();

            return choice;
        }
        #endregion

        #region 1 - Triangle (Submenu)(Method):
        public static void TopicTriangle(DataBase db)
        {
            Console.Clear();
            Console.WriteLine("1 - Add new triangle into the table:");
            Console.WriteLine("2 - Show all triangles from the table");
            Console.WriteLine("3 - Edit triangle by Id");
            Console.WriteLine("4 - Delete triangle by Id");
            Console.WriteLine("5 - Return back");
            Console.Write("\nChoose any one of the figures..");
            int choice1 = int.Parse(Console.ReadLine());
            switch (choice1)
            {
                case 1:
                    Console.Clear();
                    Triangle tr = SetTriangle(out name, out type, out a, out b, out c, out area, out perim, out tops, out edges);
                    try
                    {
                        result = db.Add($"insert into Triangles([Name],[Type],[A],[B],[C],[Area],[Perimeter],[Tops],[Edges]) values('{name}','{type}',{a},{b},{c},'{area}','{perim}',{tops},{edges})");

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
                    List<Triangle> list = ReadFiguresFromDB.ReadAllTriangles(conn);
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(new string('-', 120));
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n{i + 1} Triangle:\n");
                        Console.ForegroundColor = RandColors()[rand.Next(0, 5)];
                        Console.WriteLine(list[i]);
                        Console.ResetColor();
                        Console.WriteLine("\n" + new string('-', 120));
                    }
                    Pause();
                    break;
                case 3:
                    Console.Write("Enter any id of triangle to Update: ");
                    int editId = int.Parse(Console.ReadLine());

                    Triangle editTr = SetTriangle(out name, out type, out a, out b, out c, out area, out perim, out tops, out edges);
                    string editQuery = $"Update Triangles SET Name='{name}',Type='{type}',A={a},B={b},C={c} where Id={editId}";
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
                        Console.WriteLine("\nTriangle has updated successfull!!!");
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
                    Console.Write("Enter any id of triangle to Delete from the table: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    string delQuery = $"Delete from Triangles where Id={deleteId}";
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
                        Console.WriteLine("\nTriangle has deleted successfully!!!");
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

        #region 2 - Quadrangles (Submenu)(Method):
        public static int Quadrangles_Submenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("1 - Square");
            Console.WriteLine("2 - Rectangle");
            Console.WriteLine("3 - Rhomb");
            Console.WriteLine("4 - Parallelogram");
            Console.WriteLine("5 - Trapeze");
            Console.WriteLine("0 - Back to main menu");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + new string('-', 120));
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Choose any one of the Figures..");
            int choice = int.Parse(Console.ReadLine());
            Console.ResetColor();

            return choice;
        }
        #endregion

        #region Quadrangles (Switch Menu):
        public static void SelectFigure(DataBase db, int figure)
        {
            switch (figure)
            {
                case 1:
                    string name, type;
                    float a, area, perim;
                    int tops, edges, result1 = 0;

                    Console.Clear();
                    Console.WriteLine("1 - Add new square in the table:");
                    Console.WriteLine("2 - Show all squares from the table");
                    Console.WriteLine("3 - Edit square by Id");
                    Console.WriteLine("4 - Delete square by Id");
                    Console.WriteLine("5 - Return back");
                    Console.Write("\nChoose any one of the figures..");
                    int choice1 = int.Parse(Console.ReadLine());
                    switch (choice1)
                    {
                        case 1:
                            Console.Clear();
                            Square tr = SetSquare(out name, out type, out a, out area, out perim, out tops, out edges);
                            try
                            {
                                result = db.Add($"Insert into Squares([Name],[Type],[A],[Area],[Perimeter],[Tops],[Edges]) values('{name}','{type}',{a},'{area}','{perim}',{tops},{edges})");

                                Console.ForegroundColor = (result == "Insert was Successfull!Congratulations!!!") ? ConsoleColor.Green : ConsoleColor.Red;
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
                            List<Square> list = ReadFiguresFromDB.ReadAllSquares(conn);
                            for (int i = 0; i < list.Count; i++)
                            {
                                Console.WriteLine(new string('-', 120));
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine($"\n{i + 1} Square:\n");
                                Console.ForegroundColor = RandColors()[rand.Next(0, 5)];
                                Console.WriteLine(list[i]);
                                Console.ResetColor();
                                Console.WriteLine("\n" + new string('-', 120));
                            }
                            Pause();
                            break;
                        case 3:
                            Console.Write("Enter any id of square to Update: ");
                            int editId = int.Parse(Console.ReadLine());

                            Square editSq = SetSquare(out name, out type, out a, out area, out perim, out tops, out edges);
                            string editQuery = $"Update Squares SET Name='{name}',Type='{type}',A={a} where Id={editId}";
                            try
                            {
                                result1 = db.Update(editQuery);
                            }
                            catch (Exception ex)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(ex.Message);
                                Console.ResetColor();
                                Pause();
                            }
                            if (result1 == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nSquare has updated successfully!!!");
                                Console.ResetColor();
                                Pause();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"\nThe method of Update() return {result1}\nSomething went wrong...Try to fix this!");
                                Console.ResetColor();
                                Pause();
                            }
                            break;
                        case 4:
                            Console.Write("Enter any id of square to Delete from the table: ");
                            int deleteId = int.Parse(Console.ReadLine());
                            string delQuery = $"Delete from Squares where Id={deleteId}";
                            try
                            {
                                result1 = db.Delete(delQuery);
                            }
                            catch (Exception ex)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(ex.Message);
                                Console.ResetColor();
                                Pause();
                            }
                            if (result1 == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nSquare has deleted successfully!!!");
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
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("1 - Add new parallelogram into the table:");
                    Console.WriteLine("2 - Show all parallelograms from the table");
                    Console.WriteLine("3 - Edit parallelogram by Id");
                    Console.WriteLine("4 - Delete parallelogram by Id");
                    Console.WriteLine("5 - Return back");
                    Console.Write("\nChoose any one of the figures..");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            Parallelogram pr = SetParallelogram(out name, out type, out a, out b, out h, out area, out perim, out tops, out edges);
                            try
                            {
                                result = db.Add($"Insert into Parallelograms([Name],[Type],[A],[B],[H],[Area],[Perimeter],[Tops],[Edges]) values('{name}','{type}',{a},{b},{h},'{area}','{perim}',{tops},{edges})");

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
                            List<Parallelogram> list = ReadFiguresFromDB.ReadAllParallelograms(conn);
                            for (int i = 0; i < list.Count; i++)
                            {
                                Console.WriteLine(new string('-', 120));
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine($"\n{i + 1} Parallelogram:\n");
                                Console.ForegroundColor = RandColors()[rand.Next(0, 5)];
                                Console.WriteLine(list[i]);
                                Console.ResetColor();
                                Console.WriteLine("\n" + new string('-', 120));
                            }
                            Pause();
                            break;
                        case 3:
                            Console.Write("Enter any id of parallelogram to Update: ");
                            int editId = int.Parse(Console.ReadLine());

                            Parallelogram editPar = SetParallelogram(out name, out type, out a, out b, out h, out area, out perim, out tops, out edges);
                            string editQuery = $"Update Parallelograms SET Name='{name}',Type='{type}',A={a}, B={b}, H={h},here Id={editId}";
                            try
                            {
                                result1 = db.Update(editQuery);
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
                                Console.WriteLine("\nParallelogram has updated successfully!!!");
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
                            Console.Write("Enter any id of parallelogram to Delete from the table: ");
                            int deleteId = int.Parse(Console.ReadLine());
                            string delQuery = $"Delete from Parallelograms where Id={deleteId}";
                            try
                            {
                                result1 = db.Delete(delQuery);
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
                                Console.WriteLine("\nParallelogram has deleted successfully!!!");
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
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("1 - Add new rectangle into the table:");
                    Console.WriteLine("2 - Show all rectangles from the table");
                    Console.WriteLine("3 - Edit rectangle by Id");
                    Console.WriteLine("4 - Delete rectangle by Id");
                    Console.WriteLine("5 - Return back");
                    Console.Write("\nChoose any one of the figures..");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            Rectangle rct = SetRectangle(out name, out type, out a, out b, out area, out perim, out tops, out edges);
                            try
                            {
                                result = db.Add($"Insert into Rectangles([Name],[Type],[A],[B],[Area],[Perimeter],[Tops],[Edges]) values('{name}','{type}',{a},{b},'{area}','{perim}',{tops},{edges})");

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
                            List<Rectangle> list = ReadFiguresFromDB.ReadAllRectangles(conn);
                            for (int i = 0; i < list.Count; i++)
                            {
                                Console.WriteLine(new string('-', 120));
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine($"\n{i + 1} Rectangle:\n");
                                Console.ForegroundColor = RandColors()[rand.Next(0, 5)];
                                Console.WriteLine(list[i]);
                                Console.ResetColor();
                                Console.WriteLine("\n" + new string('-', 120));
                            }
                            Pause();
                            break;
                        case 3:
                            Console.Write("Enter any id of rectangle to Update: ");
                            int editId = int.Parse(Console.ReadLine());

                            Rectangle editRct = SetRectangle(out name, out type, out a, out b, out area, out perim, out tops, out edges);
                            string editQuery = $"Update Rectangles SET Name='{name}',Type='{type}',A={a}, B={b}, here Id={editId}";
                            try
                            {
                                result1 = db.Update(editQuery);
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
                                Console.WriteLine("\nRectangles has updated successfully!!!");
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
                            Console.Write("Enter any id of rectangle to Delete from the table: ");
                            int deleteId = int.Parse(Console.ReadLine());
                            string delQuery = $"Delete from Rectangles where Id={deleteId}";
                            try
                            {
                                result1 = db.Delete(delQuery);
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
                                Console.WriteLine("\nRectangle has deleted successfully!!!");
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
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("1 - Add new rhomb into the table:");
                    Console.WriteLine("2 - Show all rhombs from the table");
                    Console.WriteLine("3 - Edit rhomb by Id");
                    Console.WriteLine("4 - Delete rhomb by Id");
                    Console.WriteLine("5 - Return back");
                    Console.Write("\nChoose any one of the figures..");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            Rhomb rhmb = SetRhomb(out name, out type, out a, out h, out area, out perim, out tops, out edges);
                            try
                            {
                                result = db.Add($"Insert into Rhombs([Name],[Type],[A],[H],[Area],[Perimeter],[Tops],[Edges]) values('{name}','{type}',{a},{h},'{area}','{perim}',{tops},{edges})");

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
                            List<Rhomb> list = ReadFiguresFromDB.ReadAllRhombs(conn);
                            for (int i = 0; i < list.Count; i++)
                            {
                                Console.WriteLine(new string('-', 120));
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine($"\n{i + 1} Rhomb:\n");
                                Console.ForegroundColor = RandColors()[rand.Next(0, 5)];
                                Console.WriteLine(list[i]);
                                Console.ResetColor();
                                Console.WriteLine("\n" + new string('-', 120));
                            }
                            Pause();
                            break;
                        case 3:
                            Console.Write("Enter any id of rhomb to Update: ");
                            int editId = int.Parse(Console.ReadLine());

                            Rhomb editRhmb = SetRhomb(out name, out type, out a, out h, out area, out perim, out tops, out edges);
                            string editQuery = $"Update Rhombs SET Name='{name}',Type='{type}',A={a}, H={h}, here Id={editId}";
                            try
                            {
                                result1 = db.Update(editQuery);
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
                                Console.WriteLine("\nRhombs has updated successfully!!!");
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
                            Console.Write("Enter any id of rhomb to Delete from the table: ");
                            int deleteId = int.Parse(Console.ReadLine());
                            string delQuery = $"Delete from Rhombs where Id={deleteId}";
                            try
                            {
                                result1 = db.Delete(delQuery);
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
                                Console.WriteLine("\nRhomb has deleted successfully!!!");
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
                    }
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("1 - Add new trapeze into the table:");
                    Console.WriteLine("2 - Show all trapezes from the table");
                    Console.WriteLine("3 - Edit trapeze by Id");
                    Console.WriteLine("4 - Delete trapeze by Id");
                    Console.WriteLine("5 - Return back");
                    Console.Write("\nChoose any one of the figures..");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            Trapeze trpz = SetTrapeze(out name, out type, out a, out b, out c, out d, out h, out area, out perim, out tops, out edges);
                            try
                            {
                                result = db.Add($"Insert into Trapezes([Name],[Type],[A],[B],[C],[D],[H],[Area],[Perimeter],[Tops],[Edges]) values('{name}','{type}',{a},{b},{c},{d},{h},'{area}','{perim}',{tops},{edges})");

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
                            List<Trapeze> list = ReadFiguresFromDB.ReadAllTrapezes(conn);
                            for (int i = 0; i < list.Count; i++)
                            {
                                Console.WriteLine(new string('-', 120));
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine($"\n{i + 1} Trapeze:\n");
                                Console.ForegroundColor = RandColors()[rand.Next(0, 5)];
                                Console.WriteLine(list[i]);
                                Console.ResetColor();
                                Console.WriteLine("\n" + new string('-', 120));
                            }
                            Pause();
                            break;
                        case 3:
                            Console.Write("Enter any id of trapeze to Update: ");
                            int editId = int.Parse(Console.ReadLine());

                            Trapeze editTrpz = SetTrapeze(out name, out type, out a, out b, out c, out d, out h, out area, out perim, out tops, out edges);
                            string editQuery = $"Update Trapezes SET Name='{name}',Type='{type}',A={a}, B={b}, C={c}, D={d}, H={h}, here Id={editId}";
                            try
                            {
                                result1 = db.Update(editQuery);
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
                                Console.WriteLine("\nRTrapezes has updated successfully!!!");
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
                            Console.Write("Enter any id of trapeze to Delete from the table: ");
                            int deleteId = int.Parse(Console.ReadLine());
                            string delQuery = $"Delete from Trapezes where Id={deleteId}";
                            try
                            {
                                result1 = db.Delete(delQuery);
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
                                Console.WriteLine("\nTrapeze has deleted successfully!!!");
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
                    }
                    break;
            }
        }
        #endregion

        #region Set Triangle (Method):
        public static Triangle SetTriangle(out string name, out string type, out float a, out float b, out float c,
       out float area, out float perim, out int tops, out int edges)
        {
            Console.Write("Set Name of Triangle: ");
            name = Console.ReadLine();

            Console.Write("Set Type of Triangle: ");
            type = Console.ReadLine();

            Console.Write("Enter 3 sides of triangle:\n");
            Console.Write("a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("b: ");

            b = float.Parse(Console.ReadLine());
            Console.Write("c: ");
            c = float.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(a, b, c);
            triangle.Name = name;
            triangle.Type = type;
            area = triangle.Area();
            perim = triangle.Perimeter();
            tops = triangle.QuantityOfTops();
            edges = triangle.QuantityOfEdges();

            return triangle;
        }
        #endregion

        #region Set Square (Method):
        public static Square SetSquare(out string name, out string type, out float a,
           out float area, out float perim, out int tops, out int edges)
        {
            Console.Write("Set Name of Square: ");
            name = Console.ReadLine();

            Console.Write("Set Type of Square: ");
            type = Console.ReadLine();

            Console.Write("Enter a side of Square:\n");
            Console.Write("a: ");
            a = float.Parse(Console.ReadLine());

            Square square = new Square(a);
            square.Name = name;
            square.Type = type;
            area = square.Area();
            perim = square.Perimeter();
            tops = square.QuantityOfTops();
            edges = square.QuantityOfEdges();

            return square;
        }
        #endregion

        #region Set Rectangle (Method):
        public static Rectangle SetRectangle(out string name, out string type, out float a, out float b,
           out float area, out float perim, out int tops, out int edges)
        {
            Console.Write("Set Name of Rectangle: ");
            name = Console.ReadLine();

            Console.Write("Set Type of Rectangle: ");
            type = Console.ReadLine();

            Console.Write("Enter a side of Rectangle:\n");
            Console.Write("a: ");
            Console.Write("Enter b side of Rectangle:\n");
            Console.Write("b: ");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(a, b);
            rectangle.Name = name;
            rectangle.Type = type;
            area = rectangle.Area();
            perim = rectangle.Perimeter();
            tops = rectangle.QuantityOfTops();
            edges = rectangle.QuantityOfEdges();

            return rectangle;
        }
        #endregion

        #region Set Parallelogram (Method):
        public static Parallelogram SetParallelogram(out string name, out string type, out float a, out float b,
           out float h, out float area, out float perim, out int tops, out int edges)
        {
            Console.Write("Set Name of Parallelogram: ");
            name = Console.ReadLine();

            Console.Write("Set Type of Parallelogram: ");
            type = Console.ReadLine();

            Console.Write("Enter a side of Rectangle:\n");
            Console.Write("a: ");
            Console.Write("Enter b side of Rectangle:\n");
            Console.Write("b: ");
            Console.Write("Enter h:\n");
            Console.Write("h: ");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            h = float.Parse(Console.ReadLine());

            Parallelogram parallelogram = new Parallelogram(a, b, h);
            parallelogram.Name = name;
            parallelogram.Type = type;
            area = parallelogram.Area();
            perim = parallelogram.Perimeter();
            tops = parallelogram.QuantityOfTops();
            edges = parallelogram.QuantityOfEdges();

            return parallelogram;
        }
        #endregion

        #region Set Rhomb (Method):
        public static Rhomb SetRhomb(out string name, out string type, out float a, out float h,
           out float area, out float perim, out int tops, out int edges)
        {
            Console.Write("Set Name of Rhomb: ");
            name = Console.ReadLine();

            Console.Write("Set Type of Rhomb: ");
            type = Console.ReadLine();

            Console.Write("Enter a side of Rhomb:\n");
            Console.Write("a: ");
            Console.Write("Enter h:\n");
            Console.Write("h: ");
            a = float.Parse(Console.ReadLine());
            h = float.Parse(Console.ReadLine());

            Rhomb rhomb = new Rhomb(a, h);
            rhomb.Name = name;
            rhomb.Type = type;
            area = rhomb.Area();
            perim = rhomb.Perimeter();
            tops = rhomb.QuantityOfTops();
            edges = rhomb.QuantityOfEdges();

            return rhomb;
        }
        #endregion

        #region Set Trapeze (Method):
        public static Trapeze SetTrapeze(out string name, out string type, out float a, out float b,
           out float c, out float d, out float h, out float area, out float perim, out int tops, out int edges)
        {
            Console.Write("Set Name of Trapeze: ");
            name = Console.ReadLine();

            Console.Write("Set Type of Trapeze: ");
            type = Console.ReadLine();

            Console.Write("Enter a side of Trapeze:\n");
            Console.Write("a: ");
            Console.Write("Enter b side of Trapeze:\n");
            Console.Write("b: ");
            Console.Write("Enter c side of Trapeze:\n");
            Console.Write("c: ");
            Console.Write("Enter d side of Trapeze:\n");
            Console.Write("d: ");
            Console.Write("Enter h of Trapeze:\n");
            Console.Write("h: ");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            d = float.Parse(Console.ReadLine());
            h = float.Parse(Console.ReadLine());

            Trapeze trapeze = new Trapeze(a, b, c, d, h);
            trapeze.Name = name;
            trapeze.Type = type;
            area = trapeze.Area();
            perim = trapeze.Perimeter();
            tops = trapeze.QuantityOfTops();
            edges = trapeze.QuantityOfEdges();

            return trapeze;
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
