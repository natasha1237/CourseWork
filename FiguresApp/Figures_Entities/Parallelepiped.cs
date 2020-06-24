namespace FiguresApp.Figures_Entities
{
    public class Parallelepiped : Figure3D
    {
        public Parallelepiped() { }
        public Parallelepiped(double a, double b, double h) : base(a, b, h) { }

        // Properties override:
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override double A { get => a; set { a = value; } }
        public override double H { get => h; set { h = value; } }
        public override double B { get => b; set { b = value; } }
        public override double Volumee { get { return volume; } set { volume = value; } }
        public override double Areaa { get { return area; } set { area = value; } }
        public override int Sides { get { return sides; } set { sides = value; } }
        public override int Edges { get { return edges; } set { edges = value; } }
        public override int Tops { get { return tops; } set { tops = value; } }

        // Methods overrride:
        public override double Volume() => volume = a * b * h;
        public override double Area()
        {
            double sideArea;
            sideArea = ((a + b) * 2) * h;
            return area = sideArea + 2 * (a * b);
        }
        public override int QuantityOfSides() => 6;
        public override int QuantityOfTops() => 8;
        public override int QuantityOfEdges() => 12;

        public override string Info() => "Parallelepiped";
        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nType: {Type}\na: {A}\nh: {H}\nb: {B}\nVolume: {Volumee}\nArea: {Areaa}\nSides: {Sides}\nTops: {Tops}\nEdges: {Edges}\n";
        }
    }
}
