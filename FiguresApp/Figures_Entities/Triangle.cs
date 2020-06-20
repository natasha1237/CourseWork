namespace FiguresApp.Figures_Entities
{
    using Figures.EntityData;
    using Figures.EntityData._2D_Figures;
    using System.Collections.Generic;

    public class Triangle : IFigure2D
    {
        float a, b, c; // Sides of a triangle
        float area, perimeter;
        int tops, edges;

        public Triangle() { }

        public Triangle(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int Id { get; set; }
        public string Name { get; set; } 
        public string Type { get; set; }
        public float A { get { return a; } set { a = value; } }
        public float B { get { return b; } set { b = value; } }
        public float C { get { return c; } set { c = value; } }

        public float Areaa { get { return area; } set { area = value; } }
        public float Perim { get { return perimeter; } set { perimeter = value; } }
        public int Tops { get { return tops; } set { tops = value; } }
        public int Edges { get { return edges; } set { edges = value; } }

        public float Area()
        {
            double p = Perimeter() / 2;
            double S = System.Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            area = (float)S;
            return (float)S;
        }

        public float Perimeter() => perimeter = a + b + c;

        public int QuantityOfTops() => tops = new float[] { a, b, c }.Length;

        public int QuantityOfEdges() => edges = new float[] { a, b, c }.Length;

        public void InputParameters(IPrinter printer)
        {

        }

        public IEnumerable<IParameter> Parameters { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nType: {Type}\na: {A}\nb: {B}\nc: {C}\nArea: {Area()}\nPerimeter: {Perimeter()}\nTops: {Tops}\nEdges: {Edges}\n";
        }
    }
}
