using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Square : ISqure
    {
        public double Side { get; private set; }

        public Square(double side)
        {
            Side = side;
        }

        public double CalculateArea()
        {
            return Side * Side;
        }
    }
}
