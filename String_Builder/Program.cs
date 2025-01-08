using System.Text;

string name = "Emran";
name = "MD. " + name;

StringBuilder stringBuilder = new StringBuilder(name);
stringBuilder.Append("Hossen");
Console.WriteLine(stringBuilder);

var result = stringBuilder.ToString();
Console.WriteLine(result);
for(int i = 0; i < stringBuilder.Length; i++)
{
    Console.WriteLine(stringBuilder[i]);
}