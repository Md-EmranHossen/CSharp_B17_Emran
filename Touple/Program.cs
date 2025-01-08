(int, int) GetTwoRandomNumber(){
    Random random = new Random(DateTime.Now.Nanosecond);
    int n1 = random.Next(1, 200);
    int n2 = random.Next(2, 400);
    return (n1, n2);
}


var result = GetTwoRandomNumber();
Console.WriteLine(result.Item1);
Console.WriteLine(result.Item2);


(string, double)[] things = new (string, double f)[20];


void Test((string x, DateTime y) items)
{

}

