using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Admin : Base
    {
        public override void GenerateId()
        {
            id = "AD-" + Guid.NewGuid().ToString();
        }
    }
}
