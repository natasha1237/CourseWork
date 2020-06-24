namespace Figures.EntityData._3D_Figures
{
    public interface IFigure3D : IFigure
    {
        int Id { get; set; }
        double Volume();
        int QuantityOfSides();
    }
}
