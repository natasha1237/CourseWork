using System.Data.Entity.ModelConfiguration.Configuration;

namespace FiguresApp.Figures_Entities
{
    public class Pyramid : Figure3D
    {
        public Pyramid() { }
        public Pyramid(double a, double b, double h, double l) : base(a, b, h, l) { }

        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override double A { get { return a; } set { a = value; } }
        public override double B { get { return b; } set { b = value; } }
        public override double H { get { return h; } set { h = value; } }
        public override double L { get { return l; } set { l = value; } }
        public override double Volumee { get { return volume; } set { volume = value; } }
        public override double Areaa { get { return area; } set { area = value; } }
        public override int Sides { get { return sides; } set { sides = value; } }
        public override int Edges { get { return edges; } set { edges = value; } }
        public override int Tops { get { return tops; } set { tops = value; } }

        // Methods overrride:
        public override double Volume()
        {
            volume = ((a * b) / 3) * h;
            return volume;
        }
        public override double Area()
        {
            double sideArea = (((a + b) * 2) / 2) * l; // l = апофема
            return area = sideArea + a * b;
        }
        public override int QuantityOfSides() => 5;
        public override int QuantityOfTops() => 5;
        public override int QuantityOfEdges() => 8;

        public override string Info() => "Pyramid";
        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nType: {Type}\na: {A}\nb: {B}\nh: {H}\nl: {L}\nVolume: {Volumee}\nArea: {Areaa}\nSides: {Sides}\nTops: {Tops}\nEdges: {Edges}\n";
        }
    }
}
