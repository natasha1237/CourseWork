namespace Figures.Entity_Data._2D_Figures
{
    using System.Collections.Generic;

    public interface IFigure2D : IFigure
    {
        IEnumerable<IParameter> Parameters { get; }
        float Perimeter();

    }
}
