namespace FiguresApp.Figures_Entities
{
    class Parallelepiped : Figure3D
    {
        public Parallelepiped(float a, float b, float h) : base(a, b, h) { }

        // Properties override:
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override float A { get => a; set { a = value; } }
        public override float H { get => h; set { h = value; } }
        public override float B { get => b; set { b = value; } }
        public override float Volumee { get { return volume; } }
        public override float Areaa { get { return area; } }
        public override int Sides { get { return sides; } }
        public override int Edges { get { return edges; } }
        public override int Tops { get { return tops; } }

        // Methods overrride:
        public override float Volume() => a * b * h;
        public override float Area()
        {
            float sideArea;
            sideArea = ((a + b) * 2) * h;
            return area = sideArea + 2 * (a * b);
        }
        public override int QuantityOfSides() => 6;
        public override int QuantityOfTops() => 8;
        public override int QuantityOfEdges() => 12;
    }
}
