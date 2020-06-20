namespace FiguresApp.Figures_Entities
{
    public class Trapeze : Quadrangle
    {
        public Trapeze() { }
        public Trapeze(float a, float b,float c, float d, float h) : base(a, b, c, d, h) { }

        public override int  Id { get; set; }
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override float A { get; set; }
        public override float B { get; set; }
        public override float C { get; set; }
        public override float D { get; set; }
        public override float H { get; set; }
        public override float Areaa { get => base.area; set => base.area = value; }
        public override float Perim { get => base.perim; set => base.perim = value; }

        public override float Perimeter() => perim = a + b + c + d;
        public override float Area() => area = ((a + b) / 2) * h;
        public override int Tops
        {
            get { return sizeof(int); }
            set { tops = value; }
        }
        public override int Edges
        {
            get { return sizeof(int); }
            set { edges = value; }
        }
    }
}
