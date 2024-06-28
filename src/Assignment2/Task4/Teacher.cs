using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Teacher : Base
    {
        public override void GenerateId()
        {
            id = "TE-" + DateTime.Now.Ticks.ToString();
        }
    }
}
