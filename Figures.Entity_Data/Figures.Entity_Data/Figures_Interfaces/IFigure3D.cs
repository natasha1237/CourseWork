namespace Figures.Entity_Data._3D_Figures
{
    using Figures.Entity_Data._2D_Figures;

    public interface IFigure3D : IFigure
    {
        IFigure2D Base { get; }
        IEdge Height { get; }
        IAngle Incline { get; }
        float Volume();
        int QuantityOfSides();
    }
}
