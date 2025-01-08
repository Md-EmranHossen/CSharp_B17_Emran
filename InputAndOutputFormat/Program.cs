string numline = "1,2,3,4";

string[] nums = numline.Split(',');

for(int i= 0; i < nums.Length; i++)
{
    nums[i] = nums[i].Trim();
}


int[] number = new int[nums.Length];

for(int i = 0; i < nums.Length; i++)
{
    number[i] = int.Parse(nums[i]);
}

int sum = 0;
foreach(var x in number)
{
    sum += x;
}
Console.WriteLine(sum);