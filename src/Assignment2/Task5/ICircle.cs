using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal interface ICircle
    {
        double Radius { get; }
       
        double CalculateArea();
    }
}
