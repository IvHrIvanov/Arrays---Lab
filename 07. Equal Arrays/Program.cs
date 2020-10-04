using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputOne = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] inputTwo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            int index = 0;
            bool flag = false;
            for (int i = 0; i < inputOne.Length; i++)
            {
                int currentNumberOne = inputOne[i];
                int currentNumberTwo = inputTwo[i];
                if (currentNumberOne == currentNumberTwo)
                {
                    sum += currentNumberOne;
                }
                else
                {
                    flag = true;
                    break;                         
                }
                index++;
            }
            if (flag)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");

            }
            else
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
