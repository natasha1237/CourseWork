namespace FiguresApp.Figures_Entities
{
    using Figures.EntityData;
    using Figures.EntityData._2D_Figures;
    using Figures.EntityData._3D_Figures;

    class Prism : IFigure3D
    {
        public string Name { get; }
        public string Type { get; }

        public IFigure2D Base { get; }
        public IEdge Height { get; }
        
        public Prism(IFigure2D Base, IEdge Height)
        {
            this.Base = Base;
            this.Height = Height;
        }

        public float Volume()
        {
            double p = (a + b + c) / 2;
            double S = System.Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            areaBase = (float)S;
            Volume = areaBase * Height;
           
        }
        public float Area()
        {
            int sideArea;
            sideArea = ((a + b) * 2) * Height;
            Area = sideArea + 2 * (a * b);
        }

        public int QuantityOfSides()
        {
            return 5;
        }

        public int QuantityOfTops()
        {
            return 6;
        }

        public int QuantityOfEdges() // ребро
        {
            return 9;
        }

        public void InputParameters(IPrinter printer)
        {

        }
    }
}
