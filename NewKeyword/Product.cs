using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKeyword
{
    public class Product
    {

        public string Name { get; set; }
        public string FormatName() 
        {
            return Name.Length > 150 ? Name.Substring(0, 150) : Name;
        }
    }
}
