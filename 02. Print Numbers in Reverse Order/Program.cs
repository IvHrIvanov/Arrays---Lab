using System;
using System.Linq;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] arr = new int[input];
            for (int i = 0; i < input; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = input - 1; i >= 0; i--)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
