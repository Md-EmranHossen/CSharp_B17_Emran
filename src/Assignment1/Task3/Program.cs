string numLine = Console.ReadLine();
string[] nums = numLine.Split(',');
for (int i = 0; i < nums.Length; i++) {
  nums[i] = nums[i].Trim();
}
double[] numbers = new double[nums.Length];
for (int i = 0; i < nums.Length; i++) {
  numbers[i] = double.Parse(nums[i]);
}
double x = -1e9;
double y = -1e9;
for (int i = 0; i < numbers.Length; i++) {
  if (numbers[i] > x) {
    y = x;
    x = numbers[i];
  }
}
Console.WriteLine(y);