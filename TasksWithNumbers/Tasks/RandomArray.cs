using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksWithNumbers.Tasks
{
    public static class RandomArray
    {
        public static void FillArray()
        {
            Console.WriteLine("Enter length of an array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                numbers[i] = rnd.Next(0, 99);
                if(i >= 3 && i % 3 == 0)
                {
                    numbers[i - 1] = numbers[i - 2] * numbers[i];
                }
            }

            foreach(var num in numbers)
            {
                Console.WriteLine(num + " ");
            }
        }
    }
}
