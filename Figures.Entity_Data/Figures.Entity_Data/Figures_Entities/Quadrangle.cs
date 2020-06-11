namespace Figures.Entity_Data.Figures_Entities
{
    using Figures.Entity_Data._2D_Figures;
    using System;

    public class Quadrangle //: IFigure2D
    {
        float a, b;

        public Quadrangle(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public System.Collections.Generic.IEnumerable<IParameter> Parameters { get; set; }

        //public float Area()
        //{
        //    double p = Perimeter() / 2;
        //  //  double S = System.Math.Sqrt(p * (p - a) * (p - b) * (p));
        //    return (float)S;
        //}

        public float Perimeter() => (float)Math.Pow(a + b, 2);

        public int QuantityOfTops() => new float[] { a, b }.Length;

        public int QuantityOfEdges() => new float[] { a, b }.Length;

        public void InputParameters(IPrinter printer)
        {

        }
    }
}
