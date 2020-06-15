namespace Figures.UI
{
    using System;
    using Figures.Logic;
    using Figures.Entity_Data;
    using System.Configuration;
    using System.Collections.Generic;
    using Figures.Entity_Data.Figures_Entities;

    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            DataBase db = new DataBase(@"DESKTOP-LTPHR86\CLOVER", "Figures");

            string name, type, result = "";
            float a, b, c, area, perim;
            int tops, edges, choice = 0, result1 = 0;

            do
            {
                Console.Clear();
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1 - Add new triangle in the table:");
                        Console.WriteLine("2 - Show all triangles from the table");
                        Console.WriteLine("3 - Edit triangle by Id");
                        Console.WriteLine("4 - Delete triangle by Id");
                        Console.WriteLine("5 - Return back");
                        Console.Write("\nChose any one of the figures..");
                        int choice1 = int.Parse(Console.ReadLine());
                        switch (choice1)
                        {
                            case 1:
                                Console.Clear();                              
                                Triangle tr = SetTriangle(out name, out type, out a, out b, out c, out area, out perim, out tops, out edges);
                                try
                                {
                                    result = db.Add($"insert into Triangles(Name,Type,A,B,C,Area,Perimeter,Tops,Edges) values('{name}','{type}',{a},{b},{c},{area},{perim},{tops},{edges})");

                                    Console.ForegroundColor = (result == "Insert was Successfully!Congratulation!!!") ? ConsoleColor.Green : ConsoleColor.Red;
                                    Console.WriteLine(result);
                                    Console.ResetColor();
                                    Pause();
                                }
                                catch(Exception ex)
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
                                List<Triangle> list = ReadFromDatabase.ReadAllTriangles(conn);
                                for(int i = 0; i < list.Count; i++)
                                {
                                    Console.WriteLine(new string('-', 120));
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine($"\n{i + 1} Triangle:\n");
                                    Console.ForegroundColor = RandColors()[rand.Next(0, 5)];
                                    Console.WriteLine(list[i]);
                                    Console.ResetColor();
                                    Console.WriteLine("\n"+new string('-', 120));
                                }
                                Pause();
                                break;
                            case 3:
                                Console.Write("Enter any id of triangle to Update: ");
                                int editId = int.Parse(Console.ReadLine());

                                Triangle editTr = SetTriangle(out name, out type, out a, out b, out c, out area, out perim, out tops, out edges);
                                string editQuery = $"Update Triangles SET Name='{name}',Type='{type}',A={a},B={b},C={c},Area={area},Perimeter={perim},Tops={tops},Edges={edges} where Id={editId}";
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
                                    Console.WriteLine("\nTriangle has updated successfully!!!");
                                    Console.ResetColor();
                                    Pause();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"\nThe method of an Update() return {result1}\nSomething went wrong...Try to fix this!");
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
                                    Console.WriteLine("\nTriangle has deleted successfully!!!");
                                    Console.ResetColor();
                                    Pause();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"\nThe method of an Delete() return {result}\nSomething went wrong...Try to fix this!");
                                    Console.ResetColor();
                                    Pause();
                                }
                                break;
                            case 5:break;
                        }
                        break;
                }
            }
            while (choice != 0);
        }

        static int Menu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(new string('-', 120));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2D Figurs:");
            Console.WriteLine("1 - Triangle");
            Console.WriteLine("2 - Quadrangle\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("3D Figures:");
            Console.WriteLine("4 - Sphere");
            Console.WriteLine("5 - Pyramid");
            Console.WriteLine("6 - Prism");
            Console.WriteLine("7 - Parallelepiped");
            Console.WriteLine("0 - Exit");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n" + new string('-', 120));
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Choice any one the Figure..");
            int choice = int.Parse(Console.ReadLine());
            Console.ResetColor();

            return choice;
        }

        static Triangle SetTriangle(out string name, out string type, out float a, out float b, out float c,
            out float area, out float perim, out int tops, out int edges)
        {
            Console.Write("Set Name of Triangle: ");
            name = Console.ReadLine();

            Console.Write("Set Type of Triangle: ");
            type = Console.ReadLine();

            Console.Write("Enter 3 sides of a triangle:\n");
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

        static void Pause()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n\t\t\t\t\t\tPress any key to continue...");
            Console.ReadKey(true);
            Console.ResetColor();
        }

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
    }
}
