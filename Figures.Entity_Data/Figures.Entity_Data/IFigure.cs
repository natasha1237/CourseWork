namespace Figures.Entity_Data
{
    public interface IFigure
    {
        string Name { get; }
        string Type { get; }
        float Area();
        int QuantityOfTops();
        int QuantityOfEdges(); // ребро
        void InputParameters(IPrinter printer);
    }
}
