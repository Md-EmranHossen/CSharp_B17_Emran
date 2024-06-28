using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public static  class SystemDate
    {
        private static int _counter;

        static SystemDate()
        {
            _counter = 0;
        }

        public static DateTime GetCurrentDate()
        {
            _counter++;
            return DateTime.Now;
        }

        public static DateTime GetCurrentUtcDate()
        {
            _counter++;
            return DateTime.UtcNow;
        }

        public static void DisplayCounter()
        {
            Console.WriteLine(_counter);
        }
    }
}
