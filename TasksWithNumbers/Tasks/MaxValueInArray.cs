using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksWithNumbers.Tasks
{
    public static class MaxValueInArray
    {
        public static void FindMaxValueInArray()
        {
            Console.WriteLine("Enter array of numbers:");
            string[] characters = new string[0];
            string input = Console.ReadLine();
            if (input != null)
            {
                characters = input.Split(' ');
            }
            int[] numbers = new int[characters.Length];
            for (int i = 0; i < characters.Length; i++)
            {
                try
                {
                    numbers[i] = Int32.Parse(characters[i]);
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            int max = numbers[0];
            for(int i = 1; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("Maximal number is: " + max);
        }
    }
}
