using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class SystemDate
    {
        private int _counter;

        public SystemDate()
        {
            _counter = 0;
        }

        public DateTime GetCurrentDate()
        {
            _counter++;
            return DateTime.Now;
        }

        public DateTime GetCurrentUtcDate()
        {
            _counter++;
            return DateTime.UtcNow;
        }
    }
}
