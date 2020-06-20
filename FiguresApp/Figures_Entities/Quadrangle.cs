namespace FiguresApp.Figures_Entities
{
    using Figures.EntityData;
    using Figures.EntityData._2D_Figures;

    public abstract class Quadrangle : IFigure2D
    {
        protected float a, b, sin, c, d, h, area, perim, tops, edges;

        public Quadrangle() { }
        public Quadrangle(float a) { this.a = a; }

        public Quadrangle(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public Quadrangle(float a, float b, float h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }
        public Quadrangle(float a, float b, float c, float d, float h)
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
        public virtual float A { get { return a; } set { a = value; } }
        public virtual float B { get { return b; } set { b = value; } }
        public virtual float C { get { return c; } set { c = value; } }
        public virtual float D { get { return d; } set { d = value; } }
        public virtual float H { get { return h; } set { h = value; } }
        public virtual float Areaa { get; set; }
        public virtual float Perim { get; set; }

        public virtual float Area() { return 0; }
        public abstract float Perimeter();
        public virtual int Tops { get; set; }
        public virtual int Edges { get; set; }

        public int QuantityOfTops() { return 0; }
        public int QuantityOfEdges() { return 0; }
    }
}
