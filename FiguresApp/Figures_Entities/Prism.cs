namespace FiguresApp.Figures_Entities
{
    public class Prism : Figure3D
    {
        public Prism(float a, float b,float c, float h) : base(a, b, c, h) { }

        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override float A { get => a; set { a = value; } }
        public override float H { get => h; set { h = value; } }
        public override float B { get => b; set { b = value; } }
        public override float C { get => c; set { c = value; } }
        public override float Volumee { get { return volume; } }
        public override float Areaa { get { return area; } }
        public override int Sides { get { return sides; } }
        public override int Edges { get { return edges; } }
        public override int Tops { get { return tops; } }

        // Methods overrride:
        public override float Volume()
        {
            double p = (a + b + c) / 2;
            double S = System.Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            float areaBase =(float)S;
            return volume = areaBase * h;
        }
        public override float Area()
        {
            float sideArea = ((a + b) * 2) * h;
            return area = sideArea + 2 * (a * b);
        }
        public override int QuantityOfSides() => 5;
        public override int QuantityOfTops() => 6;
        public override int QuantityOfEdges() => 9;
       
    }
}
