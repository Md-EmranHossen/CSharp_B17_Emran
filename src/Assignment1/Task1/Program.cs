int n = int.Parse(Console.ReadLine());

int[,] arr = new int[n, n];

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ");
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = int.Parse(input[j]);

    }
}
int sum1 = 0;
int sum2 = 0;
int l = n - 1;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j)
        {
            sum1 += arr[i, j];
        }
        if (j == l)
        {
            sum2 += arr[i, j];
        }
    }
    l--;
}
Console.WriteLine($"1st Diagonal Sum: {sum1}");
Console.WriteLine($"2nd Diagonal Sum: {sum2}");