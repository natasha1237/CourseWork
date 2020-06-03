using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    interface IFigure
    {
        string Name { get; }
        string Type { get; }
        float Area();
        int QuantityOfTops();
        int QuantityOfEdges();// ребро
        void InputParameters(IPrinter printer);
    }
}
