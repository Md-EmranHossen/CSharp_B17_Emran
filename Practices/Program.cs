using System.Net.Security;
using System.Text;

namespace Practices
{
internal class Program
    {
        static void Main(string[] args)
        {


            string name = "Emran Hossen";

            name = "Md " + name;

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(name);
            ; stringBuilder.Append("Emran");


            string str = Convert.ToString(stringBuilder);

            for (int i = 0; i < stringBuilder.Length; i++)
            {
                Console.WriteLine(stringBuilder[i]);
            }
            
        }
    }
}
