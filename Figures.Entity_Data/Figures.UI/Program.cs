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
            DataBase db = new DataBase();

            Console.Write("Set Name of Triangle: ");
            string name = Console.ReadLine();

            Console.Write("Set Type of Triangle: ");
            string type = Console.ReadLine();

            Console.Write("Enter 3 point of a triangle:\n");
            Console.Write("a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c: ");
            float c = float.Parse(Console.ReadLine());

            Triangle tringle = new Triangle(a, b, c);
            tringle.Name = name;
            tringle.Type = type;
            float perim = tringle.Perimeter();
            float area = tringle.Area();
            int edges = tringle.QuantityOfEdges();
            float tops = tringle.QuantityOfTops();

            db.Add(name, type, a, b, c, area, perim, tops, edges);
            //Console.WriteLine($"Triangle info:\nName: {name}\nType: {type}\nArea: {area}\n" +
            //    $"Perimeter: {perim}\nQuantityOfTops: {tops}\nQuantityOfEdges: {edges}\n");

            Console.ReadKey(true);


            
            //db.Add("insert into Triangles(Name, Type, Side_A, Side_B, Side_C, Area, Perimeter, Tops, Edges, DateAdded) values('triangle', '2D Figure', 2, 3, 4, 5, 6, 3, 3, DateTime.Now)");
            
            
            //Dictionary<string, float> nameSize = new Dictionary<string, float>();
            //nameSize.Add(name, tringle.Perimeter());
           // tringle.Parameters = nameSize;
        }
    }
}
