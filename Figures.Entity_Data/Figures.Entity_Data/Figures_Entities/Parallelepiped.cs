namespace Figures.Entity_Data.Figures_Entities
{
    using Figures.Entity_Data._2D_Figures;
    using Figures.Entity_Data._3D_Figures;

    class Parallelepiped : IFigure3D
    {
        public string Name { get; }
        public string Type { get; }

        public IFigure2D Base { get; }
        public IEdge Height { get; }
        public IAngle Incline { get; }

        public Parallelepiped(IFigure2D Base, IEdge Height, IAngle Incline)
        {
            this.Base = Base;
            this.Height = Height;
            this.Incline = Incline;
        }

        public float Volume()
        {
            return 0.0f;
        }

        public int QuantityOfSides()
        {
            return 0;
        }

        public float Area()
        {
            return 0.0f;
        }

        public int QuantityOfTops()
        {
            return 0;
        }

        public int QuantityOfEdges() // ребро
        {
            return 0;
        }

        public void InputParameters(IPrinter printer)
        {

        }
    }
}
