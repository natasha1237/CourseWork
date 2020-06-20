namespace FiguresApp.Figures_Entities
{
    public abstract class Figure3D : Figures.EntityData._3D_Figures.IFigure3D
    {
        protected float a, b, c, h, l, area, volume;
        protected int sides, edges, tops;

        public Figure3D() { }
        public Figure3D(float a) { this.a = a; }
        public Figure3D(float a, float b, float h) { this.a = a; this.b = b; this.h = h; }
        public Figure3D(float a, float b, float c, float h) { this.a = a; this.b = b; this.c = c; this.h = h; }

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Type { get; set; }
        public virtual float A { get { return a; } set { a = value; } }
        public virtual float B { get { return b; } set { b = value; } }
        public virtual float C { get { return c; } set { c = value; } }
        public virtual float L { get { return l; } set { l = value; } }
        public virtual float H { get { return h; } set { h = value; } }
        public virtual float Areaa { get; set; }
        public virtual float Volumee { get; set; }

        public virtual float Area() { return 0; }
        public abstract float Volume();
        public virtual int Tops { get; set; }
        public virtual int Edges { get; set; }
        public virtual int Sides { get; set; }

        public virtual int QuantityOfTops() { return 0; }
        public virtual int QuantityOfEdges() { return 0; }
        public virtual int QuantityOfSides() { return 0; }
    }
}
