using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Electronics :Product
    {
        public override double CalculatedDiscountPrice(double amount)
        {
            return Price - amount;
        }
    }
}
