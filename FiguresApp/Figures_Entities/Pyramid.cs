namespace FiguresApp.Figures_Entities
{
    public class Pyramid : Figure3D
    {
        public Pyramid(float a, float b, float h, float l) : base(a, b, h, l) { }

        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override float A { get => a; set { a = value; } }
        public override float H { get => h; set { h = value; } }
        public override float B { get => b; set { b = value; } }
        public override float L { get => l; set { l = value; } }
        public override float Volumee { get { return volume; } }
        public override float Areaa { get { return area; } }
        public override int Sides { get { return sides; } }
        public override int Edges { get { return edges; } }
        public override int Tops { get { return tops; } }

        // Methods overrride:
      
        public override float Volume() => 1 / 3 * (a * b) * h;
        public override float Area()
        {
            float sideArea = 1 / 2 * ((a+b)*2) * l;// l = апофема
            return area = sideArea + a*b;
        }
        public override int QuantityOfSides() => 5;
        public override int QuantityOfTops() => 5;
        public override int QuantityOfEdges() => 8;
    }
}
