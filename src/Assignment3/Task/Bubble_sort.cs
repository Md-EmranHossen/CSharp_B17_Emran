using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Bubble_sort<T>
      where T : IComparable
    {
        public void Sort(T[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                bool flag = false;
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j].CompareTo(numbers[j + 1]) > 0)
                    {
                        T temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    break;
                }
            }
            foreach (T i in numbers)
            {
                Console.Write(i);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}