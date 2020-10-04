using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int currentNum = input[i];
                if (currentNum % 2 == 0)
                {
                    sum += currentNum;
                }
               
            }
            Console.WriteLine(sum);
        }
    }
}
