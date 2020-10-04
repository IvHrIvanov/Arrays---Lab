using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();



            while (input.Length != 1)
            {
                int[] condensed = new int[input.Length - 1];
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if(input[i]!=0)
                    {
                        input[i] = 0;
                    }
                    condensed[i] = input[i] + input[i + 1];

                }
                input = condensed;

            }
           
            Console.WriteLine(input[0]);

        }
    }
}
