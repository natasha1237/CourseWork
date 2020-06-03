using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    interface IAngle: IParameter
    {
        float Radians();
        float Sin();
        float Cos();
        float Tg();
        float Ctg();
    }
}
