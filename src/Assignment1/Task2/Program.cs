string numLine = Console.ReadLine();

string[] nums = numLine.Split(',');

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = nums[i].Trim();
}
int[] numbers = new int[nums.Length];

for (int i = 0; i < nums.Length; i++)
{
    numbers[i] = int.Parse(nums[i]);
}

for (int i = 0; i < numbers.Length - 1; i++)
{
    bool flag = false;
    for (int j = 0; j < numbers.Length - 1 - i; j++)
    {
        if (numbers[j] < numbers[j + 1])
        {
            numbers[j] = numbers[j] ^ numbers[j + 1];
            numbers[j + 1] = numbers[j] ^ numbers[j + 1];
            numbers[j] = numbers[j] ^ numbers[j + 1];
            flag = true;
        }
    }
    if (flag == false)
    {
        break;
    }
}
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i]);

    if (i < numbers.Length - 1)
    {
        Console.Write(", ");
    }
}