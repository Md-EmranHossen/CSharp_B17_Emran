using System;

namespace Task1
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }

        public Product() : this(0.0, string.Empty,string.Empty,string.Empty)
        {
        }
        
        public Product(double price) : this(price,string.Empty,string.Empty,string.Empty)
        {
        }

        public Product(double price, string name, string description, string color)
        {
            Price = price;
            Name = name;
            Description = description;
            Color = color;
        }
    }
}
