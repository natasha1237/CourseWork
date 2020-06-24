namespace FiguresApp.Figures_Entities
{
    public class Rhomb : Quadrangle
    {
        public Rhomb() { }
        public Rhomb(double a, double h) : base(a, h) { }

        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override double A { get => a; set { a = value; } }
        public override double H { get => base.H; set => base.H = value; }
        public override double Areaa { get { return area; } set { area = value; } }
        public override double Perim { get { return perim; } set { perim = value; } }
        public override int Edges { get { return edges; } set { edges = value; } }
        public override int Tops { get { return tops; } set { tops = value; } }

        public override double Perimeter() => perim = a * 4;
        public override double Area() 
        { 
            area = a * h;
            return area;
        }
        public override int QuantityOfTops() => sizeof(int);
        public override int QuantityOfEdges() => sizeof(int);
        public override string Info() => "Rhomb";
        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nType: {Type}\na: {A}\nh: {H}\nPerimeter: {Perim}\nArea: {Areaa}\nTops: {Tops}\nEdges: {Edges}\n";
        }
    }
}
