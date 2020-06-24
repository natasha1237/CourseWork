namespace FiguresApp.Figures_Entities
{
    public class Prism : Figure3D
    {
        public Prism() { }
        public Prism(double a, double b,double c, double h) : base(a, b, c, h) { }

        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override double A { get => a; set { a = value; } }
        public override double H { get => h; set { h = value; } }
        public override double B { get => b; set { b = value; } }
        public override double C { get => c; set { c = value; } }
        public override double Volumee { get { return volume; } set { volume = value; } }
        public override double Areaa { get { return area; } set { area = value; } }
        public override int Sides { get { return sides; } set { sides = value; } }
        public override int Edges { get { return edges; } set { edges = value; } }
        public override int Tops { get { return tops; } set { tops = value; } }

        // Methods overrride:
        public override double Volume()
        {
            double p = (a + b + c) / 2;
            double S = System.Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double areaBase =(double)S;
            return volume = areaBase * h;
        }
        public override double Area()
        {

            double p = (a + b + c) / 2;
            double S = System.Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double areaBase = (double)S;
            double sideArea = (a + b + c) * h;
            return area = sideArea + 2 * areaBase;
        }
        public override int QuantityOfSides() => 5;
        public override int QuantityOfTops() => 6;
        public override int QuantityOfEdges() => 9;

        public override string Info() => "Prism";
        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nType: {Type}\na: {A}\nb: {B}\nc: {C}\nh: {H}\nVolume: {Volumee}\nArea: {Areaa}\nSides: {Sides}\nTops: {Tops}\nEdges: {Edges}\n";
        }

    }
}
