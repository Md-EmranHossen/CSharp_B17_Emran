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

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] <= numbers[j])
        {
            numbers[i] = numbers[i] ^ numbers[j];
            numbers[j] = numbers[i] ^ numbers[j];
            numbers[i] = numbers[i] ^ numbers[j];
        }
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
