int n = int.Parse(Console.ReadLine());
int[,] arr = new int[n, n];
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = int.Parse(input[j]);
    }
}
int sum1 = 0;
int sum2 = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        sum1 += arr[i, i];
        sum2 += arr[i, n - 1 - i];
    }
}
Console.WriteLine($"1st Diagonal Sum: {sum1}");
Console.WriteLine($"2nd Diagonal Sum: {sum2}");