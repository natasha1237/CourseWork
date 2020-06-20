namespace FiguresApp.Figures_Entities
{
    public class Cube : Figure3D
    {
        public Cube (float side) : base(side) { }

        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override float A { get => a; set { a = value; } }
        public override float Volumee { get { return volume; } }
        public override float Areaa { get { return area; } }
        public override int Sides { get { return sides; } }
        public override int Edges { get { return edges; } }
        public override int Tops { get { return tops; } }

        public override float Volume() => volume = (float)System.Math.Pow(a, 3);
        public override float Area() => area = (float)System.Math.Pow(a, 2) * 6;
        public override int QuantityOfEdges() => edges = 12;
        public override int QuantityOfTops() => tops = 8;
        public override int QuantityOfSides() => sides = 6;
    }
}
