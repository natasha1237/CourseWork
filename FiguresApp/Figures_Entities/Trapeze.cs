namespace FiguresApp.Figures_Entities
{
    public class Trapeze : Quadrangle
    {
        public Trapeze() { }
        public Trapeze(double a, double b,double c, double d, double h) : base(a, b, c, d, h) { }

        public override int  Id { get; set; }
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override double A { get; set; }
        public override double B { get; set; }
        public override double C { get; set; }
        public override double D { get; set; }
        public override double H { get; set; }
        public override double Areaa { get { return area; } set { area = value; } }
        public override double Perim { get { return perim; } set { perim = value; } }
        public override int Edges { get { return edges; } set { edges = value; } }
        public override int Tops { get { return tops; } set { tops = value; } }

        public override double Perimeter() => perim = a + b + c + d;
        public override double Area() => area = ((a + b) / 2) * h;
        public override int QuantityOfTops() => sizeof(int);
        public override int QuantityOfEdges() => sizeof(int);
        public override string Info() => "Trapeze";

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nType: {Type}\na: {A}\nb: {B}\nc: {C}\nd: {D}\nh: {H}\nPerimeter: {Perim}\nArea: {Areaa}\nTops: {Tops}\nEdges: {Edges}\n";
        }
    }
}
