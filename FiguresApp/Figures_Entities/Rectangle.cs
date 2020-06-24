namespace FiguresApp.Figures_Entities
{
    public class Rectangle : Quadrangle
    {
        public Rectangle() { }
        public Rectangle(double a, double b) : base(a,b) { }

        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override double A { get; set; }
        public override double B { get; set; }
        public override double Areaa { get { return area; } set { area = value; } }
        public override double Perim { get { return perim; } set { perim = value; } }
        public override int Edges { get { return edges; } set { edges = value; } }
        public override int Tops { get { return tops; } set { tops = value; } }

        public override double Perimeter() => perim = (a + b) * 2;
        public override double Area() => area = a * b;
        public override int QuantityOfTops() => sizeof(int);
        public override int QuantityOfEdges() => sizeof(int);

        public override string Info() => "Rectangle";

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nType: {Type}\na: {A}\nb: {B}\nPerimeter: {Perim}\nArea: {Areaa}\nTops: {Tops}\nEdges: {Edges}\n";
        }
    }
}
