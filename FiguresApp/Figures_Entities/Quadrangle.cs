namespace FiguresApp.Figures_Entities
{
    using Figures.EntityData._2D_Figures;

    public abstract class Quadrangle : IFigure2D
    {
        protected double a, b, c, d, h, area, perim;
        protected int tops, edges;

        public Quadrangle() { }
        public Quadrangle(double a) { this.a = a; }

        public Quadrangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public Quadrangle(double a, double b, double h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }
        public Quadrangle(double a, double b, double c, double d, double h)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.h = h;
        }

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Type { get; set; }
        public virtual double A { get { return a; } set { a = value; } }
        public virtual double B { get { return b; } set { b = value; } }
        public virtual double C { get { return c; } set { c = value; } }
        public virtual double D { get { return d; } set { d = value; } }
        public virtual double H { get { return h; } set { h = value; } }
        public virtual double Areaa { get; set; }
        public virtual double Perim { get; set; }
        public virtual int Tops { get; set; }
        public virtual int Edges { get; set; }

        public virtual double Area() { return 0; }
        public abstract double Perimeter();
        public virtual int QuantityOfTops() { return 0; }
        public virtual int QuantityOfEdges() { return 0; }
        public virtual string Info() => string.Empty;
    }
}
