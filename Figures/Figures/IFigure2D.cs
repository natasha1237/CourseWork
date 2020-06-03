using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    interface IFigure2D : IFigure
    {
        IEnumerable<IParameter> Parameters { get; }
        float Perimeter();

    }
}
