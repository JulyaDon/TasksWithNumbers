using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksWithNumbers.Tasks
{
    public static class SumOfNumbers
    {
        public static void getSumOfNumbers()
        {
            int sum = 0;
            Console.WriteLine("Enter one integer number: ");
            var number = Int32.Parse(Console.ReadLine());
            while (number > 0)
            {
                const int i = 10;
                sum += number % i;
                number = number / i;
            }
            Console.WriteLine("Sum of all elements is " + sum);
        }
    }
}
