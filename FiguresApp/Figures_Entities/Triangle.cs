namespace FiguresApp.Figures_Entities
{
    using Figures.EntityData;
    using Figures.EntityData._2D_Figures;
    using System.Collections.Generic;

    public class Triangle : IFigure2D
    {
        double a, b, c; // Sides of a triangle
        double area, perimeter;
        int tops, edges;

        public Triangle() { }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int Id { get; set; }
        public string Name { get; set; } 
        public string Type { get; set; }
        public double A { get { return a; } set { a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double C { get { return c; } set { c = value; } }

        public double Areaa { get { return area; } set { area = value; } }
        public double Perim { get { return perimeter; } set { perimeter = value; } }
        public int Tops { get { return tops; } set { tops = value; } }
        public int Edges { get { return edges; } set { edges = value; } }

        public double Area()
        {
            double p = Perimeter() / 2;
            double S = System.Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            area = (double)S;
            return (double)S;
        }

        public double Perimeter() => perimeter = a + b + c;

        public int QuantityOfTops() => tops = new double[] { a, b, c }.Length;
        public int QuantityOfEdges() => edges = new double[] { a, b, c }.Length;
        public virtual string Info() => "Triangle";
        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nType: {Type}\na: {A}\nb: {B}\nc: {C}\nArea: {Areaa}\nPerimeter: {Perim}\nTops: {Tops}\nEdges: {Edges}\n";
        }
    }
}
