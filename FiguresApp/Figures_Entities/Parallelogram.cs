namespace FiguresApp.Figures_Entities
{
    public class Parallelogram: Quadrangle
    {
        public Parallelogram() { }
        public Parallelogram(double a, double b, double h) : base(a, b, h) { }
     
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override double A { get; set; }
        public override double B { get; set; }
        public override double H { get; set; }
        public override double Areaa { get { return area; } set { area = value; } }
        public override double Perim { get { return perim; } set { perim = value; } }
        public override int Edges { get { return edges; } set { edges = value; } }
        public override int Tops { get { return tops; } set { tops = value; } }

        public override double Perimeter() => perim = (a + b) * 2;
        public override double Area() => area = a * h;
        public override int QuantityOfTops() => sizeof(int);
        public override int QuantityOfEdges() => sizeof(int);
        public override string Info() => "Parallelogram";
        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nType: {Type}\na: {A}\nb: {B}\nh: {H}\nPerimeter: {Perim}\nArea: {Areaa}\nTops: {Tops}\nEdges: {Edges}\n";
        }
    }
}
