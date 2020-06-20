namespace FiguresApp.Figures_Entities
{
    using Figures.EntityData;
    using Figures.EntityData._2D_Figures;
    using Figures.EntityData._3D_Figures;

    class Pyramid : IFigure3D
    {
        public string Name { get; }
        public string Type { get; }

        public IFigure2D Base { get; }
        public IEdge Height { get; }
      
        public Pyramid(IFigure2D Base, IEdge Height)
        {
            this.Base = Base;
            this.Height = Height;
        }

        public float Volume()
        { 
            Volume = 1 / 3 * (a*b) * Height;
        }
        public float Area()
        {
            int sideArea;
            sideArea = 1 / 2 * ((a+b)*2) * l;// l = апофема
            Area = sideArea + a*b;
        }


        public int QuantityOfSides()
        {
            return 5;
        }

        public int QuantityOfTops()
        {
            return 5;
        }

        public int QuantityOfEdges() // ребро
        {
            return 8;
        }

        public void InputParameters(IPrinter printer)
        {

        }
    }
}
