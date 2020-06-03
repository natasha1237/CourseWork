using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    interface IFigure3D: IFigure
    {
        IFigure2D Base { get; }
        IEdge Height { get; }
        IAngle Incline { get; }
        float Volume();
        int QuantityOfSides(); 

     }
}
