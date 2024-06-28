using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public class ShoppingCart
    {
        public CartItem[] Items { get; set; }
        public double Discount { get; set; }

        public ShoppingCart(int size)
        {
            Items = new CartItem[size];
        }
        public double CalculateTotal()
        {
            var total = 0.0;
            foreach (var item in Items)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }
    }
}
