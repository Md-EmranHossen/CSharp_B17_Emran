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
            double total = 0;
            for(int i = 0; i < Items.Length; i++)
            {
                total += Items[i].Price * Items[i].Quantity;
            }

            return total;
        }
    }
}
