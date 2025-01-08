using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    internal class Person
    {
        public static int id;
        public static string Name { get; set; }

        static Person()
        {
            id = 49;
        }

        public  void PrintId()
        {
            Console.WriteLine(id);
        }
        public static void Walk()
        {

        }
    }
}
