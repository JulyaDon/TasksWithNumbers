using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksWithNumbers.Tasks
{
    public static class NumberWithWords
    {
        public static void ReplaceNumbers() { 
            //dictionary is used here to practice
            Dictionary<int, string> numbers = new Dictionary<int, string>
            {
                {0, "zero" },
                {1, "one" },
                {2, "two" },
                {3, "three" },
                {4, "four" },
                {5, "five" },
                {6, "six" },
                {7, "seven" },
                {8, "eight" },
                {9, "nine" }
            };

            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 10;
            while (number / i > 10)
            {
                i *= 10;
            }
            while (i > 0)
            {
                int n = number / i;
                Console.WriteLine(numbers[n]);
                number %= i;
                i /= 10;
            }
        }
    }
}
