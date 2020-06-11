using Figures.Entity_Data;
using Figures.Entity_Data.Figures_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase db = new DataBase("DESKTOP-LTPHR86", "Figures");

            string name, type;
            float a, b, c, area, perim;
            int tops, adges, result = 0, choice = 0;

            do
            {
                Console.Clear();
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1 - Add new Triangle in the table:");
                        Console.WriteLine("2 - Show All Triangle from the table");
                        Console.WriteLine("3 - Edit Triangle by Id");
                        Console.WriteLine("4 - Delete Triangle by Id");
                        Console.WriteLine("5 - Return back");
                        Console.Write("\nChoice any one the Figure..");
                        int choice1 = int.Parse(Console.ReadLine());
                        switch (choice1)
                        {
                            case 1:
                                Console.Clear();                              
                                Triangle tr = SetTriangle(out name, out type, out a, out b, out c, out area, out perim, out tops, out adges);
                                try
                                {
                                    result = db.Add($"insert into Triangles(Name,Type,A,B,C,Area,Perimeter,Tops,Adges) values(N'{name}',N'{type}',{a},{b},{c},{area},{perim},{tops},{adges})");
                                }
                                catch(Exception ex)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(ex.Message);
                                    Console.ResetColor();
                                    Pause();
                                }
                                if(result == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nTriangle has Added successfully!!!");
                                    Console.ResetColor();
                                    Pause();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"\nThe method of an Add() return {result}\nSomething went wrong...Try to fix this exception!");
                                    Console.ResetColor();
                                    Pause();
                                }
                                break;
                            case 2:

                                Pause();
                                break;
                            case 3:
                                Console.Write("Input any Id of triangle to Update: ");
                                int editId = int.Parse(Console.ReadLine());

                                Triangle editTr = SetTriangle(out name, out type, out a, out b, out c, out area, out perim, out tops, out adges);
                                string editQuery = $"Update Triangles SET {name},{type},{a},{b},{c},{area},{perim},{tops},{adges} where Id={editId}";
                                try
                                {
                                    result = db.Update(editQuery);
                                }
                                catch (Exception ex)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(ex.Message);
                                    Console.ResetColor();
                                    Pause();
                                }
                                if (result == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nTriangle has Updated successfully!!!");
                                    Console.ResetColor();
                                    Pause();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"\nThe method of an Update() return {result}\nSomething went wrong...Try to fix this exception!");
                                    Console.ResetColor();
                                    Pause();
                                }
                                break;
                            case 4:
                                Console.Write("Input any Id of triangle to Delete from the table: ");
                                int deleteId = int.Parse(Console.ReadLine());
                                string delQuery = $"Delete from Triangles where Id={deleteId}";
                                try
                                {
                                    result = db.Delete(delQuery);
                                }
                                catch (Exception ex)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(ex.Message);
                                    Console.ResetColor();
                                    Pause();
                                }
                                if (result == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nTriangle has Deleted successfully!!!");
                                    Console.ResetColor();
                                    Pause();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"\nThe method of an Delete() return {result}\nSomething went wrong...Try to fix this exception!");
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
            Console.ForegroundColor = ConsoleColor.Yellow;
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
    }
}
