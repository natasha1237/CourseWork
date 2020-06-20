namespace Figures.EntityData
{
    public interface IFigure
    {
        string Name { get; }
        string Type { get; }
        float Area();
        int QuantityOfTops();
        int QuantityOfEdges(); // ребро
    }
}
