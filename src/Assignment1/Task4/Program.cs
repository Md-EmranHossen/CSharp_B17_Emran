bool is_prime(int n)
{
    if (n <= 1)
    {
        return false;
    }
    else if (n == 2)
    {
        return true;
    }
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}
while (true)
{
    String str = Console.ReadLine();
    int num = int.Parse(str);
    if (num == 0)
    {
        break;
    }
    if (is_prime(num))
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}