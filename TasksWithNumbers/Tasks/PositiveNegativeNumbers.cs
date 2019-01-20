using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksWithNumbers.Tasks
{
    public static class PositiveNegativeNumbers
    {
        public static void PositiveNegativeNumbersOfArray()
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
            Console.WriteLine("Negative numbers:");
            foreach (var n in numbers)
            {
                if (n < 0)
                {
                    Console.Write(n + " ");
                }
            }
            Console.WriteLine("\nPositive numbers:");
            foreach (var n in numbers)
            {
                if (n >= 0)
                {
                    Console.Write(n + " ");
                }
            }
        }
    }
}
