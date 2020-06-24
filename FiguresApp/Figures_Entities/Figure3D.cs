namespace FiguresApp.Figures_Entities
{
    public abstract class Figure3D : Figures.EntityData._3D_Figures.IFigure3D
    {
        protected double a, b, c, h, l, area, volume;
        protected int sides, edges, tops;

        public Figure3D() { }
        public Figure3D(double a) { this.a = a; }
        public Figure3D(double a, double b, double h) { this.a = a; this.b = b; this.h = h; }
        public Figure3D(double a, double b, double h, double l) { this.a = a; this.b = b; this.h = h; this.l = l; }

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Type { get; set; }
        public virtual double A { get { return a; } set { a = value; } }
        public virtual double B { get { return b; } set { b = value; } }
        public virtual double C { get { return c; } set { c = value; } }
        public virtual double L { get { return l; } set { l = value; } }
        public virtual double H { get { return h; } set { h = value; } }
        public virtual double Areaa { get; set; }
        public virtual double Volumee { get; set; }

        public virtual double Area() { return 0; }
        public abstract double Volume();
        public virtual int Tops { get; set; }
        public virtual int Edges { get; set; }
        public virtual int Sides { get; set; }

        public virtual int QuantityOfTops() { return 0; }
        public virtual int QuantityOfEdges() { return 0; }
        public virtual int QuantityOfSides() { return 0; }

        public virtual string Info() => string.Empty;
    }
}
