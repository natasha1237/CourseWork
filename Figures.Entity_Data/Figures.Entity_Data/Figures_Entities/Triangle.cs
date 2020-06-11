namespace Figures.Entity_Data.Figures_Entities
{
    using Figures.Entity_Data._2D_Figures;
    using System.Collections.Generic;

    public class Triangle : IFigure2D
    {
        float a, b, c; // Sides of a triangle
        float area, perim;
        int top, edge;

        public Triangle() { }

        public Triangle(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string Name { get; set; } 
        public string Type { get; set; }
        public float A { get { return a; } set { a = value; } }
        public float B { get { return b; } set { b = value; } }
        public float C { get { return c; } set { c = value; } }

        public float Ar { get { return area; } set { area = value; } }
        public float Perim { get { return perim; } set { perim = value; } }
        public int Edges { get { return edge; } set { edge = value; } }
        public int Tops { get { return top; } set { top = value; } }

        public float Area()
        {
            double p = Perimeter() / 2;
            double S = System.Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            area = (float)S;
            return (float)S;
        }

        public float Perimeter()
        {
            perim = a + b + c;
            return perim;
        }

        public int QuantityOfTops()
        {
            top = new float[] { a, b, c }.Length;
            return top;
        }

        public int QuantityOfEdges()
        {
            edge = new float[] { a, b, c }.Length;
            return edge;
        }

        public void InputParameters(IPrinter printer)
        {

        }

        public IEnumerable<IParameter> Parameters { get; set; }
    }
}
