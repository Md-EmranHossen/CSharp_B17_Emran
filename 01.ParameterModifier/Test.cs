using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ParameterModifier
{
    internal class Test
    {
        public void method1(params int[] x)
        {
            int sum = 0;
            foreach(var y in x)
            {
                sum += y;
            }
            Console.WriteLine(sum);
        }


        
        public void method2(ref string x)
        {
            x = "erman";
            Console.WriteLine(x);
        }

        public void methood3(in int x)
        {
            
        }

        public void methood4(out int x)
        {
            x = 68;
        }
    }
}
