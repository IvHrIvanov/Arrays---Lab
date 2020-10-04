using System;

namespace _01._Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string[] days = new string[]
                {
                    "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday",
                    "Saturday",
                    "Sunday"
            };
            if (input < 1 || input > days.Length)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {

                Console.WriteLine(days[input - 1]);
            }
        }
    }
}
