namespace FiguresApp.Figures_Entities
{
    public class Parallelogram: Quadrangle
    {
        public Parallelogram() { }
        public Parallelogram(float a, float b, float h) : base(a, b, h) { }

        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override float A { get; set; }
        public override float B { get; set; }
        public override float H { get; set; }
        public override float Areaa { get => base.area; set => base.area = value; }
        public override float Perim { get => base.perim; set => base.perim = value; }

        public override float Perimeter()
        {
            return perim = (a + b) * 2;
        }

        public override float Area()
        {
            return area = a * h;
        }

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
