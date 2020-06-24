namespace Figures.EntityData
{
    public interface IFigure
    {
        string Name { get; }
        string Type { get; }
        double Area();
        int QuantityOfTops();
        int QuantityOfEdges(); // ребро
    }
}
