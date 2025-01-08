using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Vehicle
    {
        public string Model { get; set; }
        public abstract void StartEngine();
        public double EstimateSpeed()
        {
            throw new NotImplementedException();
        }
    }
}
