dynamic Get2RandomNumbers()
{
    Random random = new Random(DateTime.Now.Nanosecond);
    int n1 = random.Next(1, 500);
    int n2 = random.Next(1, 500);
    return new { n1 = n1, n2 = n2 };
}

var result = Get2RandomNumbers();
int x = result.n1;
int y = result.n2;