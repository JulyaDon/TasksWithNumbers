using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksWithNumbers.Tasks
{
    public static class Deviation
    {
        public static void GetNumbersWithDeviation()
        {
            int[] numbers = { 1, 2, 6, 4, 5, 3};
            int sum = 0;
            int medium = 0;
            foreach (var n in numbers)
            {
                sum += n;
            }
            Console.WriteLine("Sum: " + sum);
            medium = sum / numbers.Length;
            Console.WriteLine("Medium: " + medium);
            for (int i = 0; i < numbers.Length; i++)
            {
                const int minDeviation = 25;
                int deviation = Math.Abs((numbers[i] - medium) / medium * 100);
                if (deviation > minDeviation)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
