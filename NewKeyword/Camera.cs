using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKeyword
{
    public class Camera : Product
    {
        public new string FormatName()
        {
            return Name.Length > 100 ? Name.Substring(0, 100) : Name;
        }



    }
}
