namespace FiguresApp.Figures_Entities
{
    public class Cube : Figure3D
    {
        public Cube() { }
        public Cube (double side) : base(side) { }

        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override double A { get => a; set { a = value; } }
        public override double Volumee { get { return volume; } set { volume = value; } }
        public override double Areaa { get { return area; } set { area = value; } }
        public override int Sides { get { return sides; } set { sides = value; } }
        public override int Edges { get { return edges; } set { edges = value; } }
        public override int Tops { get { return tops; } set { tops = value; }}

        public override double Volume() => volume = (double)System.Math.Pow(a, 3);
        public override double Area() => area = (double)System.Math.Pow(a, 2) * 6;
        public override int QuantityOfEdges() => edges = 12;
        public override int QuantityOfTops() => tops = 8;
        public override int QuantityOfSides() => sides = 6;

        public override string Info() => "Cube";
        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nType: {Type}\na: {A}\nVolume: {Volumee}\nArea: {Areaa}\nSides: {Sides}\nTops: {Tops}\nEdges: {Edges}\n";
        }
    }
}
