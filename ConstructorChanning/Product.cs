using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChanning
{
    internal class Product
    {
        public Product()
            : this(0)
        {

        }
        public Product(double price)
            :this(price,10)
        {


        }

        public Product(double price, double defaultDiscount)
        {

        }
    }
}
